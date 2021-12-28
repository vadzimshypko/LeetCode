namespace LeetCode.Src.Problems
{
    /*
     * https://leetcode.com/problems/two-sum/
     */
    internal class TwoSumSolution : Solution
    {
        public void Run()
        {
            Console.WriteLine("Nums=? ? ?");
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine("Target=?");
            int target = int.Parse(Console.ReadLine());

            Solve(nums, target).ToList().ForEach(Console.WriteLine);
        }

        internal int[]? Solve(int[] nums, int target)
        {
            // value, index in arrays
            Dictionary<int, int> metNumers = new();

            for (int i = 0; i < nums.Length; i++)
            {
                if (metNumers.TryGetValue(target - nums[i], out var indexOfSecondNumber))
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