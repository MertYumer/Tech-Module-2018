namespace P06_ForeignLanguages
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string country = Console.ReadLine();
            switch (country)
            {
                case "USA":
                case "England":
                    Console.WriteLine("English");
                    break;

                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
