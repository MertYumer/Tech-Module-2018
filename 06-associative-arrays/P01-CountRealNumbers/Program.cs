using System;
using System.Linq;
using System.Collections.Generic;

namespace P01_CountRealNumbers
{
    public class Program
    {
        public static void Main()
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var counts = new SortedDictionary<double, int>();

            foreach (double number in numbers)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }

                else
                {
                    counts.Add(number, 1);
                }
            }

            foreach (var number in counts)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
