namespace P02_RepeatStrings
{
    using System;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split();

            StringBuilder concatenatedText = new StringBuilder();

            foreach (var word in words)
            {
                int count = word.Length;

                for (int i = 0; i < count; i++)
                {
                    concatenatedText.Append(word);
                }
            }

            Console.WriteLine(concatenatedText);
        }
    }
}
