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
private readonly Customer _currentCustomer;

public CustomerDashboard(Customer customer)
{
    InitializeComponent();
    _currentCustomer = customer;
    
    // Обновляем интерфейс с учетом нового объекта
    lblWelcome.Text = $"Welcome, {customer.Name}!";
    lblTotalSpent.Text = $"Total spent: {customer.TotalSpent:C}";
    lblDiscountRate.Text = $"Discount: {customer.DiscountRate:P0}";
    
    // Загрузка истории заказов
    LoadOrderHistory();
}

private void LoadOrderHistory()
{
    // Логика загрузки истории заказов для текущего клиента
    var orders = new OrderService().GetCustomerOrders(_currentCustomer.CustomerId);
    dataGridViewOrders.DataSource = orders;
}
