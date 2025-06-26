using System;

namespace CabSystem
{
    public class Admin : Person
    {
        public int AdminId { get; set; } // Изменено на int для согласованности
        public string AdminUsername { get; set; }
        public string AdminPassword { get; set; }

        public Admin(int adminId, string adminUsername, string adminPassword, 
                    string name, string address, string gender) 
                    : base(name, address, gender)
        {
            AdminId = adminId;
            AdminUsername = adminUsername;
            AdminPassword = adminPassword;
        }
        
        public override string ToString()
        {
            return $"{Name}\n{Address}\n{Gender}";
        }
    }
}
