using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_MergingLists
{
    public class Program
    {
        public static void Main()
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int smallerLength = Math.Min(firstList.Count, secondList.Count);
            List<int> mixedList = new List<int>();
            for (int i = 0; i < smallerLength; i++)
            {
                mixedList.Add(firstList[i]);
                mixedList.Add(secondList[i]);
            }
            if (firstList.Count != secondList.Count)
            {
                int biggerLength = Math.Max(firstList.Count, secondList.Count);
                for (int i = smallerLength; i < biggerLength; i++)
                {
                    if (firstList.Count > secondList.Count)
                    {
                        mixedList.Add(firstList[i]);
                    }
                    else if (firstList.Count < secondList.Count)
                    {
                        mixedList.Add(secondList[i]);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", mixedList));
        }
    }
}
