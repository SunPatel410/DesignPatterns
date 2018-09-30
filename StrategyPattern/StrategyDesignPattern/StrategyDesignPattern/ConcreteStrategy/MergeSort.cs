using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StrategyDesignPattern.Strategy;

namespace StrategyDesignPattern.ConcreteStrategy
{
    /// <summary>

    /// A 'ConcreteStrategy' class
    /// implements the algorithm using the Strategy interface
    /// </summary>
    public class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.ShellSort(); not-implemented
            Console.WriteLine("MergeSorted  list ");
        }
    }
}
