using System;
using System.Collections.Generic;

namespace P01_ReverseStrings
{
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                string word = Console.ReadLine();

                if (word == "end")
                {
                    break;
                }

                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);
                string reversedWord = new string(charArray);
                Console.WriteLine(word + " = " + reversedWord);
            }
        }
    }
}
