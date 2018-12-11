using System;

namespace P01_IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
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
