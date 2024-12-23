using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabSystem
{
    public partial class Booking : Form
    {
        IDGeneration idGenration;
        CabRental cabRental;
        DatabaseHelper dbHelper;
        private string LogInCustomer;
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public Booking(string username)
        {
            InitializeComponent();
            cabRental = new CabRental();
            idGenration = new IDGeneration();
            dbHelper = new DatabaseHelper(connectionString);
            this.LogInCustomer = username;

        }

        private void LoadingTable()
        {

            //Loading Drivers Table
            dataGridDrivers.DataSource = cabRental.LoadDriversTotable();
            dataGridDrivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in dataGridDrivers.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            //Loading Vehicle Table
            dataGridVehicles.DataSource = cabRental.LoadVehiclesToTable();
            dataGridVehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in dataGridVehicles.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

        }

        private void Booking_Load(object sender, EventArgs e)
        {
            LoadingTable();
            startDatePicker.Format = DateTimePickerFormat.Short;
            startDatePicker.MinDate = DateTime.Today;
            endDatePicker.Format = DateTimePickerFormat.Short;
            endDatePicker.MinDate = DateTime.Today;
        }

        private void dataGridVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0 && e.ColumnIndex > 0)
            {
                object carID = dataGridVehicles.Rows[e.RowIndex].Cells["CarID"].Value;

                carIdBox.Text = carID?.ToString();
            }
        }

        private void dataGridDrivers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0 && e.ColumnIndex > 0)
            {
                object driverID = dataGridDrivers.Rows[e.RowIndex].Cells["DriverID"].Value;

                driverIDBox.Text = driverID?.ToString();
            }
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            string orderID = idGenration.GenerateOrderID();
            string carID = carIdBox.Text;
            string driverID = driverIDBox.Text;
            string destination = locationBox.Text;
            DateTime startdate = startDatePicker.Value;
            DateTime endDate = endDatePicker.Value;
            Customer customer = cabRental.Customers.Find(c => c._customerUsername == LogInCustomer);
            Vechicle vechicle = cabRental.Cars.Find(v => v.CarID == carID);
            Driver driver = cabRental.Drivers.Find(d => d.DriverID == driverID);

            if (string.IsNullOrEmpty(carID) || string.IsNullOrEmpty(driverID) || string.IsNullOrEmpty(destination))
            {
                MessageBox.Show("Please Fill All the Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cabRental.CarAvailability(carID) || cabRental.CheckVehicleOrders(driverID))
            {
                MessageBox.Show("Car is already on a trip", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cabRental.CheckingDriverOrders(driverID) || cabRental.DriverAvailability(driverID))
            {
                MessageBox.Show("Driver is already on a trip", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Orders newOrder = new Orders(orderID, customer.CustomerID, customer.Name, driverID, carID, destination, startdate, endDate);
                cabRental.Orders.Add(newOrder);
                dbHelper.AddOrdersToDatabase(newOrder);
                vechicle.Availability = "Booked";
                driver.Availability = "Booked";

                dbHelper.UpdateDriverStatus(driver);
                dbHelper.UpdateCarStatus(vechicle);
                MessageBox.Show($"Vehicle Booked Successfully!\nOrder ID{orderID}\n Name{customer.Name}\n CarID{carID}\n DriverID{driverID}\n Location{destination}\n Start Date{startdate.ToShortDateString()}\n End Date{endDate.ToShortDateString()}","Order Placed",MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridDrivers.DataSource = null;
                dataGridDrivers.DataSource = cabRental.LoadDriversTotable();
                dataGridVehicles.DataSource = null;
                dataGridVehicles.DataSource = cabRental.LoadVehiclesToTable();

            }


        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.CloseButton_Click(sender, e, this);
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.MinimizeBtn_Click(sender, e, this);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            CustomerDashboard customerDashboard = new CustomerDashboard(LogInCustomer);
            this.Close();
            customerDashboard.Show();
        }

        private void dataGridVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0 && e.ColumnIndex > 0)
            {
                object carID = dataGridVehicles.Rows[e.RowIndex].Cells["CarID"].Value;

                carIdBox.Text = carID?.ToString();
            }

        }

        private void dataGridDrivers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0 && e.ColumnIndex > 0)
            {
                object driverID = dataGridDrivers.Rows[e.RowIndex].Cells["DriverID"].Value;

                driverIDBox.Text = driverID?.ToString();
            }
        }
    }
}
