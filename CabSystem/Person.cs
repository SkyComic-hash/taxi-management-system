using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabSystem
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        public Person(string name, string address, string gender)
        {
            Name = name;
            Address = address;
            Gender = gender;
        }

        public abstract override string ToString();
    }
}
