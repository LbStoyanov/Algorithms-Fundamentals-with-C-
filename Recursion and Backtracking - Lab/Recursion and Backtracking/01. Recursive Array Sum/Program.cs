using System;
using System.Linq;

namespace _01._Recursive_Array_Sum
{
    public class Program
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(RecursiveArraySum(nums,0));
        }

        private static int RecursiveArraySum(int[] nums, int i)
        {
            if (i >= nums.Length)
            {
                return 0;
            }

            return nums[i] + RecursiveArraySum(nums, i + 1);
        }
    }
}
