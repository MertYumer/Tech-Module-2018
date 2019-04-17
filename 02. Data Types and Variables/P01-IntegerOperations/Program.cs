namespace P01_IntegerOperations
{
    using System;

    public class Program
    {
        public static void Main()
        {
            long firstNumber = long.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            firstNumber += secondNumber;
            firstNumber /= thirdNumber;
            firstNumber *= fourthNumber;

            Console.WriteLine(firstNumber);
        }
    }
}
