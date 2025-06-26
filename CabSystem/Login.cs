using System;
using System.Windows.Forms;
using CabSystem.Services;

namespace CabSystem
{
    public partial class Login : Form
    {
        // Публичные свойства для передачи данных в Program.cs
        public UserType LoggedInUserType { get; private set; }
        public int LoggedInUserId { get; private set; }

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
            ButtonClicks.MinimizeBtn_Click(sender, e, this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Оставлено без изменений
        }

        private void Login_Load(object sender, EventArgs e)
        {
            LoginComboBox();
        }

        // Инициализация ComboBox с типами пользователей
        private void LoginComboBox()
        {
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Items.Add("Admin");
            comboBox.Items.Add("Customer");
            comboBox.Items.Add("Driver"); // Добавлен водитель
        }
        
        // Обработка входа
        private void Loginbutton_Click(object sender, EventArgs e)
        {
            LoginValidations loginValidations = new LoginValidations();
            string username = usernameText.Text;
            string password = passwordText.Text;
            string userType = comboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(userType) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please Fill in all Fields", "Error Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (userType == "Admin")
                {
                    var admin = loginValidations.AdminLoginValidation(username, password);
                    if (admin != null)
                    {
                        LoggedInUserType = UserType.Admin;
                        LoggedInUserId = admin.AdminID;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearInputs();
                    }
                }
                else if (userType == "Customer")
                {
                    var customer = loginValidations.CustomerLoginValidation(username, password);
                    if (customer != null)
                    {
                        LoggedInUserType = UserType.Customer;
                        LoggedInUserId = customer.UserId;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearInputs();
                    }
                }
                else if (userType == "Driver") // Обработка входа водителя
                {
                    var driver = loginValidations.DriverLoginValidation(username, password);
                    if (driver != null)
                    {
                        LoggedInUserType = UserType.Driver;
                        LoggedInUserId = driver.DriverId;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearInputs();
                    }
                }
            }
        }

        // Переход на страницу регистрации
        private void customerRegister_Click(object sender, EventArgs e)
        {
            CustomerSignUp customerSignUp = new CustomerSignUp();
            this.Hide();
            customerSignUp.Show();
        }

        // Очистка полей ввода
        private void ClearInputs()
        {
            comboBox.SelectedIndex = 0;
            usernameText.Clear();
            passwordText.Clear();
        }

        // Переключение видимости пароля
        private void PasscheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordText.UseSystemPasswordChar = !PasscheckBox.Checked;
        }
    }
}
