using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabSystem
{
    public partial class PersonalDetails : Form
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private string LogInUser;
        public PersonalDetails(string username)
        {
            InitializeComponent();
            this.LogInUser = username;
        }
        private void Edit_Click(object sender, EventArgs e)
        {

            nameBox.ReadOnly = false;
            passwordBox.ReadOnly = false;
            addressBox.ReadOnly = false;
            contactBox.ReadOnly = false;
            saveBtn.Enabled = true;
        }

        private void LoadCustomerDetails()
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Customers WHERE CustomerUsername = @Username";
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", LogInUser);

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                nameBox.Text = reader["CustomerName"].ToString();
                                usernameBox.Text = reader["CustomerUsername"].ToString();
                                passwordBox.Text = reader["CustomerPassword"].ToString();
                                addressBox.Text = reader["CustomerAddress"].ToString();
                                contactBox.Text = reader["CustomerContact"].ToString();

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Server" + ex.Message, "Connection Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PersonalDetails_Load(object sender, EventArgs e)
        {
            LoadCustomerDetails();
            saveBtn.Enabled = false;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using(SqlConnection  connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "UPDATE Customers SET CustomerName = @CustomerName, CustomerPassword = @CustomerPassword, CustomerAddress = @CustomerAddress, CustomerContact = @CustomerContact WHERE CustomerUsername = @CustomerUsername";
                    using(SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerName",nameBox.Text);
                        command.Parameters.AddWithValue("@CustomerPassword", passwordBox.Text);
                        command.Parameters.AddWithValue("@CustomerAddress", addressBox.Text);
                        command.Parameters.AddWithValue("@CustomerContact", contactBox.Text);
                        command.Parameters.AddWithValue("@CustomerUsername", LogInUser);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            nameBox.ReadOnly = true;
                            passwordBox.ReadOnly = true;
                            addressBox.ReadOnly = true;
                            contactBox.ReadOnly = true;
                            saveBtn.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Failed to update details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Server" + ex.Message, "Connection Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            CustomerDashboard customerDashboard = new CustomerDashboard(LogInUser);
            this.Close();
            customerDashboard.Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.CloseButton_Click(sender, e, this);
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.MinimizeBtn_Click(sender, e, this);
        }
    }
}
