namespace P01_DayOfWeek
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string[] days = new string[7] {"Monday", "Tuesday", "Wednesday", "Thursday",
                "Friday", "Saturday", "Sunday" };

            int day = int.Parse(Console.ReadLine());

            if (day > 7 || day < 1)
            {
                Console.WriteLine("Invalid day!");
            }

            else
            {
                Console.WriteLine(days[day - 1]);
            }
        }
    }
}
