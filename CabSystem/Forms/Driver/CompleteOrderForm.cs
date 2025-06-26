public partial class CompleteOrderForm : Form
{
    private readonly OrderModel order;
    private readonly PricingService pricingService = new PricingService();

    public CompleteOrderForm(OrderModel order)
    {
        InitializeComponent();
        this.order = order;
        
        // Показываем информацию о заказе
        lblOrderId.Text = order.OrderId.ToString();
        lblCustomer.Text = $"Клиент ID: {order.CustomerId}";
        lblPredictedCost.Text = order.PredictedCost.ToString("C");
    }

    private void btnComplete_Click(object sender, EventArgs e)
    {
        if (order.ActualStartTime.HasValue)
        {
            order.ActualEndTime = DateTime.Now;
            TimeSpan duration = order.ActualEndTime.Value - order.ActualStartTime.Value;
            
            // Рассчитываем фактическую стоимость
            order.ActualCost = pricingService.CalculateActualCost(
                (decimal)duration.TotalMinutes,
                order.Customer.DiscountRate
            );
            
            // Обновляем статистику клиента
            order.Customer.TotalSpent += order.ActualCost;
            new DiscountService().UpdateCustomerDiscount(order.Customer);
            
            // Сохраняем изменения
            new OrderService().CompleteOrder(order.OrderId, order.ActualEndTime.Value);
            
            MessageBox.Show($"Поездка завершена! Стоимость: {order.ActualCost:C}");
            Close();
        }
        else
        {
            MessageBox.Show("Время начала поездки не установлено!");
        }
    }
}
