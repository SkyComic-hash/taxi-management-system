public class OrderService
public OrderModel GetActiveOrderByDriverId(int driverId)
{
    // В реальном приложении здесь будет запрос к базе данных
    // Это пример с тестовыми данными
    
    return orders.FirstOrDefault(o => 
        o.DriverId == driverId && 
        (o.Status == "Accepted" || o.Status == "InProgress"));
}
{
    private List<OrderModel> orders = new List<OrderModel>();
    private readonly PricingService pricingService = new PricingService();

    public void CreateOrder(OrderModel order)
    {
        order.Status = OrderStatus.Pending;
        orders.Add(order);
    }

    public void CompleteOrder(int orderId, DateTime actualEndTime)
    {
        var order = orders.FirstOrDefault(o => o.OrderId == orderId);
        if (order != null && order.ActualStartTime.HasValue)
        {
            order.ActualEndTime = actualEndTime;
            order.Status = OrderStatus.Completed;
            
            // Расчет фактической стоимости
            TimeSpan duration = actualEndTime - order.ActualStartTime.Value;
            order.ActualCost = pricingService.CalculateActualCost(
                (decimal)duration.TotalMinutes, 
                order.Customer.DiscountRate
            );
        }
    }

    public List<OrderModel> GetCustomerOrders(int customerId)
    {
        return orders.Where(o => o.CustomerId == customerId).ToList();
    }
}
