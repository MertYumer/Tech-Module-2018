using System;
using System.Text.RegularExpressions;
using System.Text;

namespace P07_HTMLParser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string firstPattern = @"<title>(?<title>[\w\d\s]+)<\/title>";
            string secondPattern = @"[\\n>]([^\\n][\w\d\s]+)[<\/]";

            string input = Console.ReadLine();
            Match matchedTitle = Regex.Match(input, firstPattern);
            string title = matchedTitle.Groups["title"].Value;

            string editedInput = input.Replace(title, "");
            input = editedInput;

            MatchCollection matchedContent = Regex.Matches(input, secondPattern);
            StringBuilder content = new StringBuilder();

            foreach (Match match in matchedContent)
            {
                content.Append(match.Groups[1].Value);
                content.Append(" ");
            }

            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Content: {content}");
        }
    }
}
