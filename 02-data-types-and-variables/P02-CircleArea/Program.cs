using System;

namespace P02_CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double rarius = double.Parse(Console.ReadLine());
            double area = Math.PI * rarius * rarius;
            Console.WriteLine($"{area:f12}");
        }
    }
}
