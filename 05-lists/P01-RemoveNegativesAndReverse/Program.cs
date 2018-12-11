using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_RemoveNegativesAndReverse
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            numbers.RemoveAll(n => n < 0);

            if (numbers.Count > 0)
            {
                numbers.Reverse();
                Console.WriteLine(string.Join(" ", numbers));
            }

            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
