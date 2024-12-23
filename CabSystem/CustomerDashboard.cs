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
    public partial class CustomerDashboard : Form
    {
        private string LogInUser;
        CabRental cabRental;
        DatabaseHelper dbHelper;
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public CustomerDashboard(string username)
        {
            InitializeComponent();
            this.LogInUser = username;
            cabRental = new CabRental();
            dbHelper = new DatabaseHelper(connectionString);
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.CloseButton_Click(sender, e, this);
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.MinimizeBtn_Click(sender, e, this);
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            string customerName = dbHelper.GetCustomerNameByUsername(LogInUser);
            if (customerName != null)
            {
                nameBox.Text = customerName;
            }

            dataGridDrivers.DataSource = cabRental.LoadDriversTotable();
            dataGridDrivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach(DataGridViewColumn column in dataGridDrivers.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }


            dataGridVehicles.DataSource = cabRental.LoadVehiclesToTable();
            dataGridVehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach(DataGridViewColumn col in dataGridVehicles.Columns)
            {
                col.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        private void Personal_Details_Click(object sender, EventArgs e)
        {
            PersonalDetails personalDetails = new PersonalDetails(LogInUser);
            this.Hide();
            personalDetails.Show();
        }

        private void ordersbutton_Click(object sender, EventArgs e)
        {
            PersonalOrders personalOrders = new PersonalOrders(LogInUser);
            this.Hide();
            personalOrders.Show();
        }

        private void Rentbutton_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking(LogInUser);
            this.Hide();
            booking.Show();
        }
    }
}
