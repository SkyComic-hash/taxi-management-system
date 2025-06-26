using System;
using System.Windows.Forms;
using CabSystem.Models;
using CabSystem.Services;

namespace CabSystem.Forms.Driver
{
    public partial class DriverDashboard : Form
    {
        private readonly DriverModel currentDriver;
        private OrderModel currentOrder;
        private readonly OrderService orderService = new OrderService();

        public DriverDashboard(DriverModel driver)
        {
            InitializeComponent();
            currentDriver = driver;
            lblWelcome.Text = $"Welcome, {driver.Name}!";
            lblCarInfo.Text = $"Assigned car: {GetCarInfo()}";
            
            LoadActiveOrder();
        }

        private string GetCarInfo()
        {
            // Здесь должна быть логика получения информации о назначенном автомобиле
            // Например: 
            // var car = new CarService().GetCarById(currentDriver.CarId.Value);
            // return $"{car.Make} {car.Model} ({car.LicensePlate})";
            
            return "Toyota Camry (AA1234BB)"; // Заглушка для примера
        }

        private void LoadActiveOrder()
        {
            currentOrder = orderService.GetActiveOrderByDriverId(currentDriver.DriverId);
            
            if (currentOrder != null)
            {
                lblOrderInfo.Text = $"Order #{currentOrder.OrderId} to {currentOrder.EndLocation}";
                btnStartRide.Enabled = true;
                btnCompleteOrder.Enabled = true;
            }
            else
            {
                lblOrderInfo.Text = "No active orders";
                btnStartRide.Enabled = false;
                btnCompleteOrder.Enabled = false;
            }
        }

        private void btnStartRide_Click(object sender, EventArgs e)
        {
            if (currentOrder != null)
            {
                currentOrder.Status = "InProgress";
                currentOrder.ActualStartTime = DateTime.Now;
                orderService.UpdateOrder(currentOrder);
                
                MessageBox.Show("Ride started! Timer is running.");
                btnStartRide.Enabled = false;
            }
        }

        private void btnCompleteOrder_Click(object sender, EventArgs e)
        {
            if (currentOrder != null && currentOrder.ActualStartTime.HasValue)
            {
                CompleteOrderForm completeForm = new CompleteOrderForm(currentOrder);
                if (completeForm.ShowDialog() == DialogResult.OK)
                {
                    LoadActiveOrder(); // Обновляем статус заказа
                }
            }
            else
            {
                MessageBox.Show("Please start the ride first!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadActiveOrder();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();
        }
    }
}
