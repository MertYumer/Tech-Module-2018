namespace P09_MultiplyEvensByOdds
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int result = GetMultipleOfEvensAndOdds(Math.Abs(int.Parse(Console.ReadLine())));
            Console.WriteLine(result);
        }

        public static int GetMultipleOfEvensAndOdds(int number)
        {
            int evenSum = SumOfEvenDigits(number);
            int oddSum = SumOfOddDigits(number);
            return evenSum * oddSum;
        }

        public static int SumOfEvenDigits(int number)
        {
            int evenSum = 0;
            
            while (number > 0)
            {
                if ((number % 10) % 2 == 0)
                {
                    evenSum += number % 10;
                }

                number /= 10;
            }

            return evenSum;
        }

        public static int SumOfOddDigits(int number)
        {
            int oddSum = 0;
            Math.Abs(number);

            while (number > 0)
            {
                if ((number % 10) % 2 == 1)
                {
                    oddSum += number % 10;
                }

                number /= 10;
            }

            return oddSum;
        }
    }
}
