using System.Collections.Generic;
using System.Linq;
using CabSystem.Models;
using CabSystem.Services;

namespace CabSystem.Services
{
    public class UserService
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();
        private readonly DiscountService _discountService = new DiscountService();
        
        public Customer GetUserById(int userId)
        {
            return _dbHelper.GetCustomers()
                .FirstOrDefault(c => c.CustomerId == userId);
        }

        public void UpdateUser(Customer customer)
        {
            // Обновляем скидку перед сохранением
            _discountService.UpdateCustomerDiscount(customer);
            _dbHelper.UpdateCustomer(customer);
        }
    }
}
