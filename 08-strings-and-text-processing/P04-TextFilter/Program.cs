namespace P04_TextFilter
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var banList = Console.ReadLine().Split(", ").ToList();
            string text = Console.ReadLine();

            foreach (var word in banList)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}
