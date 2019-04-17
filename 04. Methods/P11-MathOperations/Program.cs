namespace P11_MathOperations
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double result = CalculateResult(double.Parse(Console.ReadLine()), Console.ReadLine(),
                double.Parse(Console.ReadLine()));

            Console.WriteLine(result);
        }

        public static double CalculateResult(double firstNumber, string @operator, double secondNumber)
        {
            double calculation = 0.0;

            switch (@operator)
            {
                case "+":
                    calculation = firstNumber + secondNumber;
                    break;

                case "-":
                    calculation = firstNumber - secondNumber;
                    break;

                case "*":
                    calculation = firstNumber * secondNumber;
                    break;

                case "/":
                    calculation = firstNumber / secondNumber;
                    break;
            }

            return calculation;
        }
    }
}
