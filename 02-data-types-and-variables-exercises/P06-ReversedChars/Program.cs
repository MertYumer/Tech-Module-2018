using System;

namespace P06_ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstInput = char.Parse(Console.ReadLine());
            char secondInput = char.Parse(Console.ReadLine());
            char thirdInput = char.Parse(Console.ReadLine());
            string text = string.Empty;
            text = text + thirdInput + " " + secondInput + " "+ firstInput;
            Console.WriteLine(text);
        }
    }
}
