using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class School
    {
        public Director Director;
        public string Name { get; set; }
        public int Number { get; set; }
        public int StudentCount { get; set; }
        public int TeacherCount { get; set; }
        public string City { get; set; }

        public School(Director director)
        {
            Director = director;
        }
        
    }
}
