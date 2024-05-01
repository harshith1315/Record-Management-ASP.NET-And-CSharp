using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class displayrecord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();
            }
        }
        private void BindGridView()
        {
            // Connection string to your database
            string connectionString = "Data Source=DESKTOP-SB056D8\\SQLEXPRESS;Initial Catalog=login;Integrated Security=True";

            // SQL query to retrieve records from the database
            string query = "SELECT recordnumber, patientname, dtype FROM records";

            // Create a connection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a command object
                SqlCommand command = new SqlCommand(query, connection);

                // Create a data adapter to execute the command
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Create a DataSet to hold the results
                DataSet dataSet = new DataSet();

                try
                {
                    // Open the connection
                    connection.Open();

                    // Fill the DataSet with the results of the query
                    adapter.Fill(dataSet);

                    // Bind the GridView to the DataSet
                    GridView1.DataSource = dataSet.Tables[0];
                    GridView1.DataBind();
                }
                catch (Exception ex)
                {
                    // Handle any errors
                    // For example, you could display an error message to the user
                }
            }
        }
    }
}