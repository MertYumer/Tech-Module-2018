namespace P06_CalculateRectangleArea
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double area = GetRectangleArea(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine(area);
        }

        public static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }
    }
}
