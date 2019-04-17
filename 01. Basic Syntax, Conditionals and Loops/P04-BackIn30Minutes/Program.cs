namespace P04_BackIn30Minutes
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 30;

            if (minutes > 59)
            {
                minutes -= 60;
                hours += 1;
                if (hours == 24)
                {
                    hours = 0;
                }
            }     
            
            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
