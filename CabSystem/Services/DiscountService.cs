public class DiscountService
{
    public void UpdateCustomerDiscount(UserModel customer)
    {
        if (customer.TotalSpent > 10000)
            customer.DiscountRate = 0.15m; // 15%
        else if (customer.TotalSpent > 5000)
            customer.DiscountRate = 0.10m; // 10%
        else if (customer.TotalSpent > 2000)
            customer.DiscountRate = 0.05m; // 5%
        else
            customer.DiscountRate = 0;
    }
}
