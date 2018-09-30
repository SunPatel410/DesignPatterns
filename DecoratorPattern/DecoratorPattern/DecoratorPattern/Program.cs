using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.ConcreteConponent;
using DecoratorPattern.ConcreteDescorator;

namespace DecoratorPattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            var car = new Suzuki();
            var decorator = new OfferPrice(car);

            Console.WriteLine($"Make {decorator.Make} Price {decorator.GetPrice()} + DiscountedPrice {decorator.GetDiscountedPrice()}");

            Console.ReadLine();
        }
    }
}
