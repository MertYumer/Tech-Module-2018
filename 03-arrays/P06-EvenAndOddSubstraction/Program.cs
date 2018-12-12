namespace P06_EvenAndOddSubstraction
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                }

                else
                {
                    oddSum += numbers[i];
                }
            }

            Console.WriteLine(evenSum -= oddSum);
        }
    }
}
