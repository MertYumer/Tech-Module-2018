using System;

namespace P03_Calculations
{
    public class Program
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            if (command == "add")
            {
                AddNumbers(firstNumber, secondNumber);
            }
            else if (command == "multiply")
            {
                MultiplyNumbers(firstNumber, secondNumber);
            }
            else if (command == "substract")
            {
                SubstractNumbers(firstNumber, secondNumber);
            }
            else if (command == "divide")
            {
                DivideNumbers(firstNumber, secondNumber);
            }
        }
        public static void AddNumbers(double firstNumber, double secondNumber)
        {
            Console.WriteLine(firstNumber + secondNumber);
        }
        public static void MultiplyNumbers(double firstNumber, double secondNumber)
        {
            Console.WriteLine(firstNumber * secondNumber);
        }
        public static void SubstractNumbers(double firstNumber, double secondNumber)
        {
            Console.WriteLine(firstNumber - secondNumber);
        }
        public static void DivideNumbers(double firstNumber, double secondNumber)
        {
            Console.WriteLine(firstNumber / secondNumber);
        }
    }
}
