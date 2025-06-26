using System;

namespace CabSystem
{
    public class Driver : Person
    {
        public int DriverId { get; set; } // Изменено на int для согласованности
        public string DriverPassword { get; set; }
        public string ContactNumber { get; set; } // Изменено на string для гибкости
        public string Availability { get; set; }

        // Новое поле для связи с автомобилем
        public int? CarId { get; set; }

        public Driver(int driverId, string name, string driverPassword, 
                     string address, string contactNumber, string gender) 
                     : base(name, address, gender)
        {
            DriverId = driverId;
            DriverPassword = driverPassword;
            ContactNumber = contactNumber;
            Availability = "Available";
            CarId = null;
        }

        public override string ToString()
        {
            return $"{Name}\n{Address}\n{Gender}";
        }
    }
}
