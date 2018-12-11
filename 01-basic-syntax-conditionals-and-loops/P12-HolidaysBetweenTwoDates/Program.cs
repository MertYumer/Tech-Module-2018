namespace P13_HolidaysBetweenTwoDates
{
    using System;
    using System.Globalization;

    public class Program
    {
        public static void Main()
        {
            DateTime parsedStart = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            DateTime parsedEnd = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            var holidaysCount = 0;

            for (var date = parsedStart; date <= parsedEnd; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday ||
                    date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }
            }

            Console.WriteLine(holidaysCount);
        }
    }
}
