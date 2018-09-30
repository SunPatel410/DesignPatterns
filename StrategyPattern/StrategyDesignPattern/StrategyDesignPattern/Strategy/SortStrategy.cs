using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Strategy
{
    /// <summary>
    /// The 'Strategy' abstract class => declares an interface common to all supported algorithms
    /// Context uses this interface to call the algorithm defined by a ConcreteStrategy
    /// </summary>
    public abstract  class SortStrategy 
    {
        public abstract void Sort(List<string> list);
    }
}
