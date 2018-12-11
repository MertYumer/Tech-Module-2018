namespace P09_SumOfOddNumbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int num = 1;

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(num);
                sum += num;
                num += 2;          
            }

            Console.WriteLine($" Sum: {sum}");
        }
    }
}
