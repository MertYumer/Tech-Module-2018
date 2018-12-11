using System;
using System.Linq;
using System.Collections.Generic;

namespace P02_OddOccurrences
{
    public class Program
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split().ToArray();
            var occurrences = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string currentWord = word.ToLower();
                if (occurrences.ContainsKey(currentWord))
                {
                    occurrences[currentWord]++;
                }

                else
                {
                    occurrences.Add(currentWord, 1);
                }
            }

            foreach (var occurrence in occurrences)
            {
                if (occurrence.Value % 2 == 1)
                {
                    Console.Write(occurrence.Key + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
