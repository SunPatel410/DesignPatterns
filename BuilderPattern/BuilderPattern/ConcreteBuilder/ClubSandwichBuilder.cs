using System.Collections.Generic;
using BuilderPattern.Builder;
using BuilderPattern.Product;

namespace BuilderPattern.ConcreteBuilder
{
    /// <summary>
    /// The 'ConcreteBuilder2' class
    /// </summary>
    public class ClubSandwichBuilder : SandwichBuilder
    {
        public override void AddCondiments()
        {
            sandwich.HasMayo = false;
            sandwich.HasMustard = true;
        }

        public override void ApplyVeg()
        {
            sandwich.Vegetables = new List<string>
            {
                "Tomato",
            };
        }

        public override void ApplyMeatAndCheese()
        {
            sandwich.MeatType = MeatType.Ham;
            sandwich.CheeseType = CheeseType.Provolone;
        }

        public override void PrepareBread()
        {
            sandwich.BreadType = BreadType.Wheat;
            sandwich.IsToasted = true;
        }
    }
}