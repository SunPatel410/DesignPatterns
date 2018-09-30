using System.Collections.Generic;
using BuilderPattern.Builder;
using BuilderPattern.Product;

namespace BuilderPattern.ConcreteBuilder
{
    /// <summary>
    /// The 'ConcreteBuilder1' class
    /// => Should be more than one of these
    /// => Provides an implementation for interface defined by the Builder
    /// </summary>
    public class MySandwichBuilder : SandwichBuilder
    {
        public override void AddCondiments()
        {
            sandwich.HasMayo = true;
            sandwich.HasMustard = false;
        }
        public override void ApplyVeg()
        {
            sandwich.Vegetables = new List<string>
            {
                "Tomato",
                "Onions"
            };
        }
        public override void ApplyMeatAndCheese()
        {
            sandwich.MeatType = MeatType.Turkey;
            sandwich.CheeseType = CheeseType.American;
        }
        public override void PrepareBread()
        {
            sandwich.BreadType = BreadType.White;
            sandwich.IsToasted = true;
        }
    }
}
