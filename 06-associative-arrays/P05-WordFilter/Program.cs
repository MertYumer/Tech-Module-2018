using System;
using System.Linq;

namespace P05_WordFilter
{
    public class Program
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split().Where(n => n.Length % 2 == 0).ToArray();

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
