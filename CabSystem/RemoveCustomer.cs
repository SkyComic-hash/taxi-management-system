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
    public partial class RemoveCustomer : Form
    {
        CabRental cabRental;
        DatabaseHelper dbHelper;
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public RemoveCustomer()
        {
            InitializeComponent();
            cabRental = new CabRental();
            dbHelper = new DatabaseHelper(connectionString);
        }

        private void RemoveCustomer_Load(object sender, EventArgs e)
        {
            dataGridCustomers.DataSource = cabRental.LoadCustomersToTable();
            dataGridCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in dataGridCustomers.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            string removeCusId = cusIDBox.Text;
            if (string.IsNullOrEmpty(removeCusId))
            {
                MessageBox.Show("Enter a Customer ID", "No ID Provided", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cabRental.CheckingCustomerOrder(removeCusId))
            {
                MessageBox.Show("Customer has Active Orders", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool customerRemoved = dbHelper.RemoveCustomerFromDB(removeCusId);
                if (customerRemoved)
                {
                    MessageBox.Show("Customer Removed From DataBase", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridCustomers.DataSource = null;
                    dataGridCustomers.DataSource = cabRental.LoadCustomersToTable();
                    dataGridCustomers.Refresh();
                }
                else
                {
                    MessageBox.Show("Failed to Remove Customer from Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            AdminDashboard adminDashboard = new AdminDashboard();
            this.Close();
            adminDashboard.Show();
        }
    }
}
