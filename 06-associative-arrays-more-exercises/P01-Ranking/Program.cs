using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_Ranking
{
    public class Program
    {
        public static void Main()
        {
            var contestsAndPasswords = new Dictionary<string, string>();

            var newContest = Console.ReadLine().Split(":");
            while (newContest[0] != "end of contests")
            {
                string contest = newContest[0];
                string password = newContest[1];
                contestsAndPasswords[contest] = password;
                newContest = Console.ReadLine().Split(":");
            }

            var students = new Dictionary<string, Dictionary<string, int>>();

            var submission = Console.ReadLine().Split("=>");
            while (submission[0] != "end of submissions")
            {
                string contest = submission[0];
                string password = submission[1];
                string candidate = submission[2];
                int points = int.Parse(submission[3]);

                if (contestsAndPasswords.ContainsKey(contest) &&
                    contestsAndPasswords[contest] == password)
                {
                    if (!students.ContainsKey(candidate))
                    {
                        students[candidate] = new Dictionary<string, int>();
                        students[candidate].Add(contest, points);
                    }

                    else
                    {
                        if (!students[candidate].ContainsKey(contest))
                        {
                            students[candidate].Add(contest, points);
                        }

                        else if (students[candidate][contest] < points)
                        {
                            students[candidate][contest] = points;
                        }
                    }
                }
                submission = Console.ReadLine().Split("=>");
            }

            var result = students.OrderByDescending(x => x.Value.Values.Sum()).Take(1);
            string name = string.Empty;
            int sum = 0;

            foreach (var student in result)
            {
                name = student.Key;
                foreach (var currentPoints in student.Value)
                {
                    sum += currentPoints.Value;
                }
            }
            Console.WriteLine($"Best candidate is {name} with total {sum} points.");

            Console.WriteLine("Ranking:");
            foreach (var student in students.OrderBy(x => x.Key))
            {
                Console.WriteLine(student.Key);

                foreach (var currentContest in student.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {currentContest.Key} -> {currentContest.Value}");
                }
            }
        }
    }
}
