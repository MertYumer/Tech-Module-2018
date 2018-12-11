using System;

namespace P07_TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char letter = (char)('a' + n);
            for (char i = 'a'; i < letter; i++)
            {
                for (char j = 'a'; j < letter; j++)
                {
                    for (char k = 'a'; k < letter; k++)
                    {
                        Console.Write($"{i}{j}{k}");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
