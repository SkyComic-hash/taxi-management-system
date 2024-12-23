using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabSystem
{
    public partial class CustomerSignUp : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public CustomerSignUp()
        {
            InitializeComponent();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.CloseButton_Click(sender, e, this);
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.MinimizeBtn_Click(sender, e, this);
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            IDGeneration iDGeneration = new IDGeneration();
            string gender = gendercomboBox.SelectedItem?.ToString();

            if (nameBox.Text == "" || addressBox.Text == "" || string.IsNullOrEmpty(gender) || usernametextBox.Text == "" || passwordtextBox.Text == "")
            {
                MessageBox.Show("Please Fill All the Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string customerID = iDGeneration.GenerateCustomerID();
            string name = nameBox.Text;
            string address = addressBox.Text;
           
            string username = usernametextBox.Text;
            string password = passwordtextBox.Text;
            int contact;
            if(!int.TryParse(contactBox.Text, out contact))
            {
                MessageBox.Show("Invalid Contact. Please Enter Numerical Values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DatabaseHelper databaseHelper = new DatabaseHelper(connectionString);
                bool success = databaseHelper.RegisterCustomer(customerID, name, address, gender, username, password, contact);
                if (success)
                {
                    MessageBox.Show("Registration Successfull. Please Use Provided Username and Password to Login", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login login = new Login();
                    this.Hide();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Registration Failed. Please Try again","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  
                }

            }
        }
        private void InitiateGenderBox()
        {
            gendercomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            gendercomboBox.Items.Add("Male");
            gendercomboBox.Items.Add("Female");
        }

        private void CustomerSignUp_Load(object sender, EventArgs e)
        {
            InitiateGenderBox();
        }
    }
}
