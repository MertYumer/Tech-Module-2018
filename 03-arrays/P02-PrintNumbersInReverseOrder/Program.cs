using System;
using System.Linq;

namespace P02_PrintNumbersInReverseOrder
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", numbers.Reverse()));
        }
    }
}
