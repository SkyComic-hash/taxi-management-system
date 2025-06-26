public class CarModel
{
    public int CarId { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string LicensePlate { get; set; }
    public bool IsAvailable { get; set; } = true;
    public int? DriverId { get; set; } // Прикрепленный водитель
    public DateTime? MaintenanceStart { get; set; }
    public DateTime? MaintenanceEnd { get; set; }
    public decimal BaseRatePerMinute { get; set; } = 2.0m;
}
