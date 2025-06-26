public class OrderModel
{
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public int? DriverId { get; set; }
    public int CarId { get; set; }
    public string StartLocation { get; set; }
    public string EndLocation { get; set; }
    public DateTime RequestedArrivalTime { get; set; }
    public DateTime? ActualStartTime { get; set; }
    public DateTime? ActualEndTime { get; set; }
    public decimal PredictedCost { get; set; }
    public decimal ActualCost { get; set; }
    public OrderStatus Status { get; set; } = OrderStatus.Pending;
}

public enum OrderStatus
{
    Pending,
    Accepted,
    InProgress,
    Completed,
    Cancelled
}
