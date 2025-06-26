public class OrderService
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
