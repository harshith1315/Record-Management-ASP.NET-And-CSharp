﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                Response.Redirect($"home.aspx");
            }

        }

        protected void Test(object sender, EventArgs e)
        {

            string username = user.Text;
            string password = pass.Text;

            Console.WriteLine(username + ":" + password);
            Dictionary<string, string> credentials = RetrieveUserCredentials(username, password);

            if (credentials.Count > 0)
            {
                Session["username"] = username;
                Response.Redirect($"home.aspx");
            }
            else
            {
                error.Visible = true;
                error.InnerText = "Invalid";
                error.Attributes.Add("style", "color: red;");
            }

        }

        public Dictionary<string, string> RetrieveUserCredentials(string a, string b)
        {
            Dictionary<string, string> userCredentials = new Dictionary<string, string>();
            string connectionString = "Data Source=DESKTOP-SB056D8\\SQLEXPRESS;Initial Catalog=login;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT username, password FROM Users WHERE username = @Username AND password = @Password";
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", a);
                        command.Parameters.AddWithValue("@Password", b);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string username = reader["username"].ToString();
                                string password = reader["password"].ToString();
                                userCredentials.Add(username, password);
                                return userCredentials;
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Error: " + ex.Message);
                    // You can also print out ex.StackTrace to get more detailed information about the error.
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return userCredentials;
        }
    }
}