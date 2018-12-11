using System;

namespace P10_RepeatString
{
    public class Program
    {
        public static void Main()
        {
            string result = RepeatString(Console.ReadLine(), int.Parse(Console.ReadLine()));
            Console.WriteLine(result);
        }
        public static string RepeatString(string text, int count)
        {
            string repeatedText = string.Empty;
            for (int i = 0; i < count; i++)
            {
                repeatedText += text;
            }
            return repeatedText;
        }
    }
}
