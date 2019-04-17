namespace P07_MathPower
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double finalResult = RaiseNumber(double.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine(finalResult);
        }

        public static double RaiseNumber(double number, int power)
        {
            return Math.Pow(number, power);
        }
    }
}
