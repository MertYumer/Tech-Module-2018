namespace P01_MatchFullName
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string names = Console.ReadLine();
            MatchCollection matchedNames = Regex.Matches(names, regex);

            foreach (var name in matchedNames)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
        }
    }
}
