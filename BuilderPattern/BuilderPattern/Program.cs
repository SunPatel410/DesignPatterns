using System;
using BuilderPattern.ConcreteBuilder;
using BuilderPattern.Director;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var sandwichMaker = new SandwichMaker(new MySandwichBuilder());
            sandwichMaker.BuildSandwich();
            var sandwich1 = sandwichMaker.GetSandwich();

            var sandwichMaker2 = new SandwichMaker(new ClubSandwichBuilder());
            sandwichMaker2.BuildSandwich();
            var sandwich2 = sandwichMaker.GetSandwich();


            sandwich1.Display();
            Console.WriteLine("\n********************************\n");
            sandwich2.Display();

            Console.ReadKey();
        }
    }
}
