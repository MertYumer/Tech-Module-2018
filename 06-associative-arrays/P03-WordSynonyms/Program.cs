using System;
using System.Linq;
using System.Collections.Generic;

namespace P03_WordSynonyms
{
    public class Program
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            var synonyms = new Dictionary<string, string>();
            string[] words = new string[lines * 2];

            for (int i = 0; i < lines; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (synonyms.ContainsKey(word))
                {
                    synonyms[word] += $", {synonym}";
                }

                else
                {
                    synonyms.Add(word, synonym);
                }
            }

            foreach (var word in synonyms)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
