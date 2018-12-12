namespace P06_SpecialNumbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            bool special = false;

            for (int i = 1; i <= num; i++)
            {
                sum = (i / 10) + (i % 10);
                special = (sum == 5 || sum == 7 || sum == 11);
                Console.WriteLine($"{i} -> {special}");
                sum = 0;
            }
        }
    }
}
