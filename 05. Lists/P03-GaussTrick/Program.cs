namespace P03_GaussTrick
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int secondIndex = numbers.Count - 1;
           
            for (int i = 0; i < secondIndex; i++)
            {
                numbers[i] = numbers[i] + numbers[secondIndex];
                numbers.Remove(numbers[secondIndex]);
                secondIndex--;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
