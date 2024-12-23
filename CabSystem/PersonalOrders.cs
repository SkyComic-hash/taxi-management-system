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
    public partial class PersonalOrders : Form
    {
        private string LogInUser;
        CabRental cabRental;
        public PersonalOrders(string username)
        {
            InitializeComponent();
            this.LogInUser = username;
            cabRental = new CabRental();
        }

        private void PersonalOrders_Load(object sender, EventArgs e)
        {
            Customer loggedInCustomer = cabRental.Customers.Find(c => c._customerUsername == LogInUser);
            if (loggedInCustomer != null)
            {
                List<Orders> customerOrders = cabRental.GetCustomerOrders(loggedInCustomer.CustomerID);
                dataGridOrders.DataSource = customerOrders;
                dataGridOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                foreach (DataGridViewColumn col in dataGridOrders.Columns)
                {
                    col.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            ButtonClicks.MinimizeBtn_Click(sender,e, this);
        }
    }
}
