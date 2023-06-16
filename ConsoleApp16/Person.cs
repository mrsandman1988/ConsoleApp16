using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class Person // base class parent class
    {
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public School School { get; set; }

        public void GetBasicInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} {Age} {City}");
        }
         public Person() {
        
        }

    }
}
