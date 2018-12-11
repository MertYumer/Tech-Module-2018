using System;
using System.Text.RegularExpressions;

namespace P02_MatchPhoneNumber
{
    public class Program
    {
        public static void Main()
        {
            string phoneNumbers = Console.ReadLine();
            string regex = @"\+([359]+)([-| ])2(\2)(\d{3})(\2)(\d{4})\b";
            MatchCollection matcheNumbers = Regex.Matches(phoneNumbers, regex);

            Console.WriteLine(string.Join(", ", matcheNumbers));
        }
    }
}
