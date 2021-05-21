using System;
using System.Linq;
using System.Collections.Generic;

namespace Aggregate
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var aggregateClass = new AggregateClass();

            aggregateClass.GetMax();

            aggregateClass.GetMin();

            aggregateClass.GetAve();

            aggregateClass.GetSum();

            aggregateClass.GetCount();

            aggregateClass.GetAgg();
        }
    }

    class AggregateClass
    {
        List<int> source = new List<int>
        {
            2, 7, 8, 4, 9, 49, 36, 3, 8, 8, 26, 78, 65
        };

        // Max()
        // Get the maximum value
        public void GetMax()
        {
            Console.WriteLine(source.Max());
        }

        // Min()
        // Get the minimum value
        public void GetMin()
        {
            Console.WriteLine(source.Min());
        }

        // Average()
        // Get the average value
        public void GetAve()
        {
            Console.WriteLine(source.Average());
        }

        // Sum()
        // Get the total
        public void GetSum()
        {
            Console.WriteLine(source.Sum());
        }

        // Count()
        // Get the number of elements
        public void GetCount()
        {
            Console.WriteLine(source.Count());
        }

        // Aggregate()
        // Get the aggregate
        public void GetAgg()
        {
            Console.WriteLine(source.Aggregate((now, next) => now + next));
        }
    }
}