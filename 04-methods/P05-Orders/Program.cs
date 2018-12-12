namespace P05_Orders
{
    using System;

    public class Program
    {
        public static void Main()
        {
            CalculatePrice(Console.ReadLine(), int.Parse(Console.ReadLine()));
        }

        public static void CalculatePrice(string product, int quantity)
        {
            if (product == "coffee")
            {
                Console.WriteLine($"{(quantity * 1.50):F2}");
            }

            else if (product == "water")
            {
                Console.WriteLine($"{(quantity * 1.00):F2}");
            }

            else if (product == "coke")
            {
                Console.WriteLine($"{(quantity * 1.40):F2}");
            }

            else if (product == "snacks")
            {
                Console.WriteLine($"{(quantity * 2.00):F2}");
            }
        }
    }
}
