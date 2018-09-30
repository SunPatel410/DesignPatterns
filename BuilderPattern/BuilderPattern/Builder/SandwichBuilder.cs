using BuilderPattern.Product;

namespace BuilderPattern.Builder
{
    /// <summary>
    /// Builder abstract class
    /// => Abstract or Interface class
    /// => Defines steps
    /// => Holds instance of Product
    /// </summary>
    public abstract class SandwichBuilder
    {
        public Sandwich sandwich;

        public Sandwich GetSandwich()
        {
            return sandwich;
        }

        public void CreateNewSandwich()
        {
            sandwich = new Sandwich();
        }

        public abstract void PrepareBread();
        public abstract void ApplyMeatAndCheese();
        public abstract void ApplyVeg();
        public abstract void AddCondiments();
    }
}
