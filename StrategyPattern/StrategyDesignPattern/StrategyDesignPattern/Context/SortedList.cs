using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StrategyDesignPattern.Strategy;

namespace StrategyDesignPattern.Context
{
    public class SortedList
    {
        private List<string> _list = new List<string>();
        private SortStrategy _sortstrategy;

        public void SetSortStrategy(SortStrategy sortstrategy)
        {
            this._sortstrategy = sortstrategy;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {
            _sortstrategy.Sort(_list);

            // Iterate over list and display results

            foreach (string name in _list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }
    }
}
