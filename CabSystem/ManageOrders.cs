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
    public partial class ManageOrders : Form
    {
        CabRental cabRental;
        DatabaseHelper dbHelper;
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public ManageOrders()
        {
            InitializeComponent();
            cabRental = new CabRental();
            dbHelper = new DatabaseHelper(connectionString);
        }

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            dataGridOrders.DataSource = cabRental.LoadingOrdersToTable();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.CloseButton_Click(sender, e, this);
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.MinimizeBtn_Click(sender,e, this);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            this.Close();
            adminDashboard.Show();
        }

        private void completeBtn_Click(object sender, EventArgs e)
        {
            string orderId = orderIDBox.Text;
            if (string.IsNullOrEmpty(orderId))
            {
                MessageBox.Show("Please enter an Order ID", "No Order ID Provided", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Orders orders = cabRental.Orders.Find(o => o.OrderID == orderId);
                if (orders == null || orders.OrderStatus != "On Going")
                {
                    MessageBox.Show("Order is already completed or no longer active", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    orders.OrderStatus = "Completed";
                    Vechicle vechicle = cabRental.Cars.Find(c => c.CarID == orders.CarID);
                    Driver driver = cabRental.Drivers.Find(d => d.DriverID == orders.DriverID);

                    if (vechicle != null)
                    {
                        vechicle.Availability = "Available";
                        dbHelper.UpdateCarStatus(vechicle);
                    }
                    if (driver != null)
                    {
                        driver.Availability = "Available";
                        dbHelper.UpdateDriverStatus(driver);
                    }

                    MessageBox.Show("Order status updated to Complete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbHelper.UpdateOrderStatus(orders);
                    dataGridOrders.DataSource = null;
                    dataGridOrders.DataSource = cabRental.LoadingOrdersToTable();
                    dataGridOrders.Refresh();
                }
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            string orderId = orderIDBox.Text;
            if (string.IsNullOrEmpty(orderId))
            {
                MessageBox.Show("Please enter an Order ID", "No Order ID Provided", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Orders orders = cabRental.Orders.Find(o => o.OrderID == orderId);
                if (orders.OrderStatus != "Completed")
                {
                    MessageBox.Show("Order is already completed or no longer active", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    dbHelper.RemoveOrder(orderId);
                    dataGridOrders.DataSource = null;
                    dataGridOrders.DataSource = cabRental.LoadingOrdersToTable();
                }

            }
        }
    }
}
