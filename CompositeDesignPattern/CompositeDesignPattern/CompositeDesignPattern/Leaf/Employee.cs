using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CompositeDesignPattern.Component;

namespace CompositeDesignPattern.Leaf
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public Employee(string name, string department)
        {
            Name = name;
            Department = department;
        }

        public void GetDetails(int indentation)
        {
            Console.WriteLine($"Name{Name}, Department{Department}, Leaf {new string('-', indentation)}");
        }
    }
}
