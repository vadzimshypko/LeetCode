using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * https://leetcode.com/problems/two-sum/
 */
namespace LeetCode
{
    internal class TwoSum : Solution
    {
        public void Run()
        {
            Console.WriteLine("Nums");
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine("Target");
            int target = int.Parse(Console.ReadLine());

            Solve(nums, target).ToList().ForEach(Console.WriteLine);
        }

        public void RunWithDefaultArguments()
        {
            Solve(new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11).ToList().ForEach(Console.WriteLine);
        }

        private int[]? Solve(int[] nums, int target)
        {
            // value, index in array
            Dictionary<int, int> metNumers = new();

            for (int i = 0; i < nums.Length; i++)
            {
                if(metNumers.TryGetValue(target - nums[i], out var indexOfSecondNumber))
                {
                    return new int[] { i, indexOfSecondNumber };
                }
                else
                {
                    metNumers.TryAdd(nums[i], i);
                }
            }

            return null;
        }
    }
}
