using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class Student:Person
    {
        public int Level { get; set; }
        public int BookCount { get; set; }
        public void GetStudentInfo()
        {
            base.GetBasicInfo();
            Console.WriteLine($"{Level } {BookCount}");
        }
    }
}
