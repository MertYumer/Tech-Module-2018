namespace P01_ReverseStrings
{
    using System;

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
