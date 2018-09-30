using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDescorator
{
    public class OfferPrice : CarDecorator
    {
        public OfferPrice(ICar car) : base(car)
        {
        }

        public override double GetDiscountedPrice() => .8 * base.GetPrice();
    }
}
