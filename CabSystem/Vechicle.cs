using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabSystem
{
    public class Vechicle
    {
        public string CarID { get; set; }
        public string Make { get; set; }
        public string Type { get; set; }
        public string VehicleType { get; set; }
        public string Model { get; set; }
        public string PlateNumber { get; set; }
        public int Year { get; set; }
        public int Cost {  get; set; }
        public string Availability { get; set; }

        public Vechicle(string carID, string make, string type,string vehicleType, string model, string plateNumber, int year, int cost)
        {
            CarID = carID;
            Make = make;
            Type = type;
            VehicleType = vehicleType;
            Model = model;
            PlateNumber = plateNumber;
            Year = year;
            Cost = cost;
            Availability = "Available";
        }
    }
}
