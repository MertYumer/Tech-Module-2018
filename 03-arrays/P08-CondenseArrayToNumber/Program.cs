using System;
using System.Linq;

namespace P08_CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstLength = nums.Length - 1;
            int finalResult = 0;
            if (nums.Length == 1)
            {
                Console.WriteLine(nums[0]);
                return;
            }
            for (int i = 0; i < firstLength; i++)
            {
                int[] condensed = new int[nums.Length - 1];
                for (int j = 0; j < condensed.Length; j++)
                {
                    condensed[j] = nums[j] + nums[j + 1];
                }
                nums = condensed;
                finalResult = condensed[0];
            }
            Console.WriteLine(finalResult);
        }
    }
}
