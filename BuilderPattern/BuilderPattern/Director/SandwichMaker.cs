using BuilderPattern.Builder;
using BuilderPattern.Product;

namespace BuilderPattern.Director
{
    /// <summary>
    /// The 'Director' class
    /// => Uses the Concrete Builder
    /// => Knows how to build
    /// => Client code calls directly
    /// </summary>
    public class SandwichMaker
    {
        private readonly SandwichBuilder _builder;

        public SandwichMaker(SandwichBuilder builder)
        {
            _builder = builder;
        }

        public void BuildSandwich()
        {
            _builder.CreateNewSandwich();
            _builder.PrepareBread();
            _builder.ApplyMeatAndCheese();
            _builder.ApplyVeg();
            _builder.AddCondiments();
        }

        public Sandwich GetSandwich()
        {
            return _builder.GetSandwich();
        }
    }
}
