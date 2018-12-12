namespace P02_CircleArea
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double rarius = double.Parse(Console.ReadLine());
            double area = Math.PI * rarius * rarius;
            Console.WriteLine($"{area:f12}");
        }
    }
}
