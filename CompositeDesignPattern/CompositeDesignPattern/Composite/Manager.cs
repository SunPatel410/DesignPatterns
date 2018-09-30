using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositeDesignPattern.Component;

namespace CompositeDesignPattern.Composite
{
    public class Manager : IEmployee
    {
        public List<IEmployee> SubOrdinates;
        public string Name { get; set; }
        public string Department { get; set; }

        public Manager(string name, string department)
        {
            Name = name;
            Department = department;
            SubOrdinates = new List<IEmployee>();
        }
        public void GetDetails(int indentation)
        {
            Console.WriteLine($"Name{Name}, Department{Department} - Manager(Composite){new string('-', indentation)}");

            foreach (var employee in SubOrdinates)
            {
                employee.GetDetails(indentation + 1);
            }
        }
    }
}
