using System.Collections.Generic;
using System.Linq;
using CabSystem.Models;

namespace CabSystem.Services
{
    public class DriverService
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();
        
        public Driver GetDriverById(int driverId)
        {
            // Реальная реализация будет из базы данных
            // Это пример с тестовыми данными
            
            return _dbHelper.GetDrivers()
                .FirstOrDefault(d => d.DriverId == driverId);
        }
    }
}
