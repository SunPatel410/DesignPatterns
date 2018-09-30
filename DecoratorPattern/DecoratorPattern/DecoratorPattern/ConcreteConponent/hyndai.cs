using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Component;

namespace DecoratorPattern.ConcreteConponent
{
    public sealed class Hyndai : ICar
    {
        public string Make => "HatchBack";
        public double GetPrice() => 800000;
    }
}
