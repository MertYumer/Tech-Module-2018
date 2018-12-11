using System;

namespace P08_GreaterOfTwoValues
{
    public class Program
    {
        public static void Main()
        {
            string valuesType = Console.ReadLine();

            switch (valuesType)
            {
                case "int":
                    GetMax(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                    break;
                case "char":
                    GetMax(char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine()));
                    break;
                case "string":
                    GetMax(Console.ReadLine(), Console.ReadLine());
                    break;
            }
        }
        public static void GetMax(int firstNumber, int secondNumber)
        {
            Console.WriteLine(Math.Max(firstNumber, secondNumber));
        }
        public static void GetMax(char firstSymbol, char secondSymbol)
        {
            Console.WriteLine((char)Math.Max(firstSymbol, secondSymbol));
        }
        public static void GetMax(string firstText, string secondText)
        {
            int comparison = firstText.CompareTo(secondText);
            if (comparison > 0)
            {
                Console.WriteLine(firstText);
            }
            else
            {
                Console.WriteLine(secondText);
            }
        }
    }
}
