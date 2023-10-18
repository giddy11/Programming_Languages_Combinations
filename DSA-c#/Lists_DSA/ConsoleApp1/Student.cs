using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public Student(string name, string address, int level)
        {
            Name = name;
            Address = address;
            Level = level;
        }

        public override string ToString()
        {
            var res = Name + " " + Address;
            return res;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public int Level { get; set; }
    }
}
