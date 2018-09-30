using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StrategyDesignPattern.ConcreteStrategy;
using StrategyDesignPattern.Context;

namespace StrategyDesignPattern
{
    class Program
    {
        /// <summary>
        /// Strategy Design Pattern
        /// Define a family of algorithms, encapsulate each one, and make them interchangeable.
        /// Strategy lets the algorithm vary independently from clients that use it.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            SortedList studentRecords = new SortedList();

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

            // Wait for user

            Console.ReadKey();
        }
    }
}
