namespace P06_ListManipulationAdvanced
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool isChanged = false;

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "end")
                {
                    if (isChanged)
                    {
                        Console.WriteLine(string.Join(" ", numbers));
                    }

                    return;
                }

                switch (command[0])
                {
                    case "Add":
                    case "Remove":
                    case "RemoveAt":
                    case "Insert":
                        isChanged = true;
                        break;
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

                    case "Contains":
                        Console.WriteLine(CheckListContent(Convert.ToInt32(command[1]), numbers)); 
                        break;

                    case "PrintEven":
                        Console.WriteLine(string.Join(" ", PrintEvenOrOddNumbers(numbers, 0)));
                        break;

                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", PrintEvenOrOddNumbers(numbers, 1)));
                        break;

                    case "GetSum":
                        Console.WriteLine(GetSum(numbers));
                        break;

                    case "Filter":
                        Console.WriteLine(string.Join(" ", Filter(numbers, 
                            command[1], Convert.ToInt32(command[2]))));
                        break;
                }
            }
        }

        public static string CheckListContent(int element, List<int> numbers)
        {
            return numbers.Contains(element) ? "Yes" : "No such number";
        }

        public static List<int> PrintEvenOrOddNumbers(List<int> numbers, int remainder)
        {
            List<int> currentList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == remainder)
                {
                    currentList.Add(numbers[i]);
                }
            }

            return currentList;
        }

        public static int GetSum(List<int> numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        public static List<int> Filter(List<int> numbers, string sign, int element)
        {
            List<int> currentList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                switch (sign)
                {
                    case ">":
                        if (numbers[i] > element)
                        {
                            currentList.Add(numbers[i]);
                        } 
                        break;

                    case ">=":
                        if (numbers[i] >= element)
                        {
                            currentList.Add(numbers[i]);
                        }
                        break;

                    case "<":
                        if (numbers[i] < element)
                        {
                            currentList.Add(numbers[i]);
                        }
                        break;

                    case "<=":
                        if (numbers[i] <= element)
                        {
                            currentList.Add(numbers[i]);
                        }
                        break;
                }
            }

            return currentList;
        }
    }
}
