using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositeDesignPattern.Composite;
using CompositeDesignPattern.Leaf;

namespace CompositeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Employee("John", "IT");
            var sunny = new Employee("Sunny", "IT");
            var peter = new Employee("Peter", "IT");
            var meh = new Employee("Meh", "IT");

            var matt = new Manager("Matt", "IT") {SubOrdinates = {john, sunny}};

            var ranj = new Manager("Ranj", "IT") { SubOrdinates = { peter, meh } };

            var bob = new Manager("Bob", "Head"){SubOrdinates = {matt, ranj}};

            ranj.GetDetails(1);
            Console.ReadLine();
        }
    }
}
