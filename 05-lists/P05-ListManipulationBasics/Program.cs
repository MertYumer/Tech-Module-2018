using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_ListManipulationBasics
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "end")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                    return;
                }

                switch (command[0])
                {
                    case "Add":
                        numbers.Add(Convert.ToInt32(command[1]));
                        break;
                    case "Remove":
                        numbers.Remove(Convert.ToInt32(command[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(Convert.ToInt32(command[1]));
                        break;
                    case "Insert":
                        numbers.Insert(Convert.ToInt32(command[2]), Convert.ToInt32(command[1]));
                        break;
                }
            }
        }
    }
}
