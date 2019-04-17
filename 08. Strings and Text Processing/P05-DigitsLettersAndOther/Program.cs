namespace P05_DigitsLettersAndOther
{
    using System;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder other = new StringBuilder();

            foreach (var character in input)
            {
                if (char.IsDigit(character))
                {
                    digits.Append(character);
                }

                else if (char.IsLetter(character))
                {
                    letters.Append(character);
                }

                else
                {
                    other.Append(character);
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(other);
        }
    }
}
