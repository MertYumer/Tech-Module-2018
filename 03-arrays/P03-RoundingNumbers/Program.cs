using System;
using System.Linq;

namespace P03_RoundingNumbers
{
    public class Program
    {
        public static void Main()
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => {numbers[i]:f0}");
            }
        }
    }
}
