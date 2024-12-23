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
    public partial class RemoveCar : Form
    {
        CabRental cabRental;
        DatabaseHelper dbHelper;
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public RemoveCar()
        {
            InitializeComponent();
            cabRental = new CabRental();
            dbHelper = new DatabaseHelper(connectionString);
        }

        private void RemoveCar_Load(object sender, EventArgs e)
        {
            dataGridVehicle.DataSource = cabRental.LoadVehiclesToTable();
            dataGridVehicle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach(DataGridViewColumn column in dataGridVehicle.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.CloseButton_Click(sender, e, this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.MinimizeBtn_Click(sender, e, this);
        }

        //Adding CarID to textbox when datagrid cell is clicked
        private void dataGridVehicle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0 && e.ColumnIndex > 0)
            {
                object removeDriverId = dataGridVehicle.Rows[e.RowIndex].Cells["CarID"].Value;
                vehicleIDBox.Text = removeDriverId?.ToString();
            }
        }

        //Remove Button Functionality
        private void removeBtn_Click(object sender, EventArgs e)
        {
            string vehicleID = vehicleIDBox.Text;
            //Handling Error where ID is not Provided
            if (string.IsNullOrEmpty(vehicleID))
            {
                MessageBox.Show("Enter a vehicle ID to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Handling Error Where Vehicle is on Trip
            else if(cabRental.CarAvailability(vehicleID) || cabRental.CheckingDriverOrders(vehicleID))
            {
                MessageBox.Show("Vehicle has Active Orders", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //removing the Vehicle from Database
                bool success = dbHelper.RemoveVehicle(vehicleID);
                if (success)
                {
                    MessageBox.Show("Vehicle Removed From DataBase", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridVehicle.DataSource = null;
                    dataGridVehicle.DataSource = cabRental.LoadVehiclesToTable();
                    dataGridVehicle.Refresh();
                }
                else
                {
                    MessageBox.Show("Failed to Remove Vehicle from Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            this.Close();
            adminDashboard.Show();
        }

        private void vehicleIDBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
