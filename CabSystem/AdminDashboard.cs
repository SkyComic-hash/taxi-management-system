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
    public partial class AdminDashboard : Form
    {
        CabRental cabRental;
        public AdminDashboard()
        {
            InitializeComponent();
            cabRental = new CabRental();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.CloseButton_Click(sender, e, this);
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.MinimizeBtn_Click(sender, e, this);
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadingDataTables();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        //Loading Add Driver Form
        private void driverAddBtn_Click(object sender, EventArgs e)
        {
            AddDriver addDriver = new AddDriver();
            addDriver.Show();
            this.Hide();
            dataGridDrivers.Refresh();
        }
        private void LoadingDataTables()
        {
            //Laoding Customer table
            dataGridCustomers.DataSource = cabRental.LoadCustomersToTable();
            dataGridCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in dataGridCustomers.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            //Loading Drivers Table
            dataGridDrivers.DataSource = cabRental.LoadDriversTotable();
            dataGridDrivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach(DataGridViewColumn column in dataGridDrivers.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            //Loading Vehicle Table
            dataGridVehicles.DataSource = cabRental.LoadVehiclesToTable();
            dataGridVehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach(DataGridViewColumn column in dataGridVehicles.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            //Loading Orders Table
            dataGridOrders.DataSource = cabRental.LoadingOrdersToTable();
            dataGridOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach(DataGridViewColumn column in dataGridOrders.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        private void carRemoveBtn_Click(object sender, EventArgs e)
        {
            RemoveCar removeCar = new RemoveCar();
            this.Hide();
            removeCar.Show();
        }

        //Loading remove Driver Form
        private void driverRemoveBtn_Click(object sender, EventArgs e)
        {
            RemoveDriver removeDriver = new RemoveDriver();
            this.Hide();
            removeDriver.Show();
        }

        private void carAddBtn_Click(object sender, EventArgs e)
        {
            AddCar addCar = new AddCar();
            addCar.Show();
            dataGridVehicles.Refresh();
            this.Hide();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            ManageOrders manageOrders = new ManageOrders();
            manageOrders.Show();
            this.Hide();
        }

        private void CustomerRemoveBtn_Click(object sender, EventArgs e)
        {
            RemoveCustomer removeCustomer = new RemoveCustomer();
            this.Hide();
            removeCustomer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonClicks.CloseButton_Click(sender, e, this);
        }
    }
}
