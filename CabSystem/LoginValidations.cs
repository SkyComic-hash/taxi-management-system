using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabSystem
{
    public class LoginValidations
    {
        private string connectionString =ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public bool AdminLoginValidation(string username, string password)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Admins WHERE AdminUsername COLLATE SQL_Latin1_General_CP1_CS_AS=@Username AND AdminPassword COLLATE SQL_Latin1_General_CP1_CS_AS=@Password";
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            return reader.Read();

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to server" + ex.Message, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool CustomerLoginValidation(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Customers WHERE CustomerUsername COLLATE SQL_Latin1_General_CP1_CS_AS=@Username AND CustomerPassword COLLATE SQL_Latin1_General_CP1_CS_AS=@Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            return reader.Read();

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to server" + ex.Message, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public bool CheckUsername(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT (*) FROM Customers WHERE CustomerUsername=@Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
