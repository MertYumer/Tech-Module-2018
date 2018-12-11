using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace P02_PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                int firstNumber = 1;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{firstNumber} ");
                    firstNumber = firstNumber * (i - j) / (j + 1);
                }
                Console.WriteLine();
            }
        }
    }
}
