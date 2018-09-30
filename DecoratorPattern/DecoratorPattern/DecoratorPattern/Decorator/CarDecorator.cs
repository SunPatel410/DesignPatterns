using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator
{
    public abstract class CarDecorator : ICar
    {
        private ICar _car;

        public CarDecorator(ICar car)
        {
            _car = car;
        }

        public string Make => _car.Make;
        public double GetPrice() => _car.GetPrice();

        public abstract double GetDiscountedPrice();
    }
}
