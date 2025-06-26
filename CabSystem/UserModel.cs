public class UserModel
{
    public int UserId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    
    // Новые поля
    public decimal TotalSpent { get; set; }
    public decimal DiscountRate { get; set; } // Скидка (0.1 для 10%)
}
