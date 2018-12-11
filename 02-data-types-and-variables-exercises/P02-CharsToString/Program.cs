using System;

namespace P02_CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstInput = char.Parse(Console.ReadLine());
            char secondInput = char.Parse(Console.ReadLine());
            char thirdInput = char.Parse(Console.ReadLine());
            string text = string.Empty;
            text = text + firstInput + secondInput + thirdInput;
            Console.WriteLine(text);
        }
    }
}
