using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StrategyDesignPattern.Strategy;

namespace StrategyDesignPattern.ConcreteStrategy
{
    public class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("QuickSort  list ");
        }
    }
}
