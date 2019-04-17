namespace P11_MultiplicationTable2._0
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            for (int i = numberTwo; i <= 10; i++)
            {
                Console.WriteLine($"{numberOne} X {i} = {numberOne * i}");
            }
            if (numberTwo > 10)
            {
                Console.WriteLine($"{numberOne} X {numberTwo} = {numberOne * numberTwo}");
            }
        }
    }
}
