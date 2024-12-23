using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.CloseButton_Click(sender, e, this);
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.MinimizeBtn_Click(sender,e, this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            LoginComboBox();
        }

        //Initiating User Type Combo box
        private void LoginComboBox()
        {
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Items.Add("Admin");
            comboBox.Items.Add("Customer");
        }
        
        //Login Button Functionality
        private void Loginbutton_Click(object sender, EventArgs e)
        {
            LoginValidations loginValidations = new LoginValidations();
            string username = usernameText.Text;
            string password = passwordText.Text;
            string userType = comboBox.SelectedItem?.ToString();

            //Handling Error where Username and Password are empty
            if(string.IsNullOrEmpty(userType) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please Fill in the all Fields", "Error Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Condition to check selected User type and Validating Login accordingly
                if(userType == "Admin")
                {
                    bool isValidLogin = loginValidations.AdminLoginValidation(username, password);

                    if (isValidLogin)
                    {
                        AdminDashboard adminDashboard = new AdminDashboard();
                        this.Hide();
                        adminDashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password","Invalid Login",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearInputs();
                    }
                }
                else if (userType == "Customer")
                {
                    bool isValidLogin = loginValidations.CustomerLoginValidation(username, password);

                    if (isValidLogin)
                    {
                        CustomerDashboard customerDashboard = new CustomerDashboard(username);
                        this.Hide();
                        customerDashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearInputs();
                    }
                }
            }
        }

        //Loading register Page when Button is clicked
        private void customerRegister_Click(object sender, EventArgs e)
        {
            CustomerSignUp customerSignUp = new CustomerSignUp();
            this.Hide();
            customerSignUp.Show();
        }

        //Clearing Inputs
        private void ClearInputs()
        {
            comboBox.SelectedIndex = 0;
            usernameText.Clear();
            passwordText.Clear();
        }

        //Making Password Hidden until Checkbox is clicked
        private void PasscheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordText.UseSystemPasswordChar = !PasscheckBox.Checked;
        }
    }
}
