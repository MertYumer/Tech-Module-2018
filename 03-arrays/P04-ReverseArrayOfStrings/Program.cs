using System;
using System.Linq;

namespace P04_ReverseArrayOfStrings
{
    public class Program
    {
        public static void Main()
        {
            string[] symbols = Console.ReadLine().Split().ToArray();
            Console.WriteLine(string.Join(" ", symbols.Reverse()));
        }
    }
}
