namespace P02_RandomizeWords
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var elements = Console.ReadLine().Split().ToList();
            Random random = new Random();

            for (int i = 0; i < elements.Count; i++)
            {
                int randomElement = random.Next(elements.Count);
                string tempElement = elements[i];
                elements[i] = elements[randomElement];
                elements[randomElement] = tempElement;
            }

            Console.WriteLine(string.Join(Environment.NewLine, elements));
        }
    }
}
