using System;
using System.Collections.Generic;

namespace CabSystem
{
    public class Customer : Person
    {
        public int CustomerId { get; set; } // Изменено на int для согласованности
        public string CustomerUsername { get; set; }
        public string CustomerPassword { get; set; }
        public string ContactNumber { get; set; } // Изменено на string для гибкости
        public List<Order> PersonalOrders { get; set; } = new List<Order>();

        // Новые поля для системы скидок
        public decimal TotalSpent { get; set; }
        public decimal DiscountRate { get; set; }

        public Customer(int customerId, string name, string customerUsername, 
                       string customerPassword, string address, string contactNumber, 
                       string gender) : base(name, address, gender)
        {
            CustomerId = customerId;
            CustomerUsername = customerUsername;
            CustomerPassword = customerPassword;
            ContactNumber = contactNumber;
            TotalSpent = 0;
            DiscountRate = 0;
        }

        public override string ToString()
        {
            return $"{Name}\n{Address}\n{Gender}";
        }
    }
}
