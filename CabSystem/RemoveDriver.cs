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
    public partial class RemoveDriver : Form
    {
        CabRental cabRental;
        DatabaseHelper dbHelper;
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public RemoveDriver()
        {
            InitializeComponent();
            cabRental = new CabRental();
            dbHelper = new DatabaseHelper(connectionString);
        }

        private void RemoveDriver_Load(object sender, EventArgs e)
        {
            dataGridDrivers.DataSource = cabRental.LoadDriversTotable();
            dataGridDrivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in dataGridDrivers.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        private void dataGridDrivers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > 0 && e.ColumnIndex > 0)
            {
                object removeDriverId = dataGridDrivers.Rows[e.RowIndex].Cells["DriverID"].Value;
                driverIDBox.Text = removeDriverId?.ToString();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            this.Close();
            adminDashboard.Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.CloseButton_Click(sender, e, this);
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.MinimizeBtn_Click(sender, e, this);
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            string driverID = driverIDBox.Text;
            if(string.IsNullOrEmpty(driverID) )
            {
                MessageBox.Show("Enter a Driver ID to remove","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cabRental.CheckingDriverOrders(driverID))
            {
                MessageBox.Show("Driver has Active Orders", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool driverRemoved = dbHelper.RemoveDriverFromDB(driverID);
                if (driverRemoved)
                {
                    MessageBox.Show("Driver Removed From DataBase", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridDrivers.DataSource = null;
                    dataGridDrivers.DataSource = cabRental.LoadDriversTotable();
                    dataGridDrivers.Refresh();
                }
                else
                {
                    MessageBox.Show("Failed to Remove Driver from Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
