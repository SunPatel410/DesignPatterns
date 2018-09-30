using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StrategyDesignPattern.Strategy;

namespace StrategyDesignPattern.ConcreteStrategy
{
    public class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("ShellSort list ");
        }
    }
}
