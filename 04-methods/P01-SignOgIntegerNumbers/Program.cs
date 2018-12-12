namespace P01_SignOgIntegerNumbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            PrintSign(int.Parse(Console.ReadLine()));
        }

        public static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }

            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }

            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
