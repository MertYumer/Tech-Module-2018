namespace P04_MatchNumbers
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string numbers = Console.ReadLine();
            var regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            MatchCollection matchedNumbers = Regex.Matches(numbers, regex);
            Console.WriteLine(string.Join(" ", matchedNumbers));
        }
    }
}
