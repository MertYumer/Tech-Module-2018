namespace P12_EvenNumber
{
    using System;

    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 != 0)
                {
                    Console.WriteLine("Please write an even number.");
                    continue;
                }

                else
                {
                    if (number < 0)
                    {
                        number *= -1;
                    }

                    Console.WriteLine($"The number is: {number}");
                    return;
                }
            }
        }
    }
}
