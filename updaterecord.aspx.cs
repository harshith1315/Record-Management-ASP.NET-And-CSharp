using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class updaterecord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateDropdown();
            }

        }
        protected void Udata(object sender,EventArgs e) 
        { 
            string rnumber=rnum.Text;
            string name= uname.Text;
            string d= dropdown.Text;
            string no = rnum.Text;
            if (!string.IsNullOrEmpty(rnumber))
            {
                string connectionString = "Data Source=DESKTOP-SB056D8\\SQLEXPRESS;Initial Catalog=login;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string insertQuery = "UPDATE records SET patientname = @n, dtype= @dt WHERE recordnumber = @num;";
                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@n", name);
                            command.Parameters.AddWithValue("@dt", d);
                            command.Parameters.AddWithValue("@num", no);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                error.Visible = true;
                                error.InnerText = "data is updated";
                            }
                            else
                            {
                                error.Visible = true;
                                error.InnerText = "No record number " + no + " not found.";
                                error.Attributes.Add("style", "color: red;");
                            }
                        }
                    }
                    catch (Exception ex) { }

                }
            }

            else
            {
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
    }
}