using System;

namespace P03_Substring
{
    public class Program
    {
        public static void Main()
        {
            string firstWord = Console.ReadLine().ToLower();
            string secondWord = Console.ReadLine().ToLower();
            int index = 0;
            string result = string.Empty;

            while (index != -1)
            {
                index = secondWord.IndexOf(firstWord);
                if (index != -1)
                {
                    secondWord = secondWord.Remove(index, firstWord.Length);
                }
            }
            
            Console.WriteLine(secondWord);
        }
    }
}
