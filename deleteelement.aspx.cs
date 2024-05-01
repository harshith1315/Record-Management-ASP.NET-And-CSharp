using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class deleterecord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Remove()
        {
            string name = dname.Text;
            if (string.IsNullOrEmpty(name))
            {

            }
            else
            {
                string connectionString = "Data Source=DESKTOP-SB056D8\\SQLEXPRESS;Initial Catalog=login;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string insertQuery = "delete from records where patientname=@name";
                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@name", name);
                            //command.Parameters.AddWithValue("@dtype", dtype);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                error.Visible=true;
                                error.InnerText = "data is deleted";
                            }
                            else
                            {

                            }
                        }
                    }catch (Exception ex) { }

                }
            }
        }
    }
}
