using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class addrecord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateDropdown();
            }

        }
        private void PopulateDropdown()
        {
            string connectionString = "Data Source=DESKTOP-SB056D8\\SQLEXPRESS;Initial Catalog=login;Integrated Security=True"; // Update with your database connection string
            string query = "SELECT username FROM users";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Assuming "username" is the field you want to display in the dropdown
                    dropdown.Items.Add(new ListItem(reader["username"].ToString()));
                }

                reader.Close();
            }
        }
        protected void data(object sender, EventArgs e)
        {
            string name = uname.Text;
            string dtype = dropdown.Text;
            string no = rnum.Text;
            string connectionString = "Data Source=DESKTOP-SB056D8\\SQLEXPRESS;Initial Catalog=login;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO records (patientname, dtype,recordnumber) VALUES (@name, @dtype, @rnumber)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@dtype", dtype);
                        command.Parameters.AddWithValue("@rnumber", no);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Redirect to home.aspx after successful insertion
                            Response.Redirect("home.aspx");
                        }
                        else
                        {
                            // If no rows were affected, show an error message
                            error.Visible = true;
                            error.InnerText = "Failed to insert record.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions appropriately, such as logging
                    error.Visible = true;
                    error.InnerText = "An error occurred: " + ex.Message;
                }
            }

        }
    }
}