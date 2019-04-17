namespace P04_ReverseArrayOfStrings
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] symbols = Console.ReadLine().Split().ToArray();
            Console.WriteLine(string.Join(" ", symbols.Reverse()));
        }
    }
}
