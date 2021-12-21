namespace LeetCode
{
    /**
     * https://leetcode.com/problems/jump-game/
     */
    internal class JumpGame : Solution
    {
        public void Run()
        {
            Console.WriteLine("nums = ?,?,?");
            int[] nums = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            Console.WriteLine(Solve(nums));
        }

        public void RunWithDefaultArguments()
        {
            Console.WriteLine(Solve(new[] { 3, 2, 1, 0, 4 }));
        }

        private bool Solve(int[] nums)
        {
            int largestAvailableIndex = 0;
            int lastIndex = nums.Length - 1;
            for (int i = 0; i <= largestAvailableIndex && largestAvailableIndex < lastIndex; i++)
            {
                largestAvailableIndex = Math.Max(largestAvailableIndex, i + nums[i]);
            }
            return nums.Length - 1 <= largestAvailableIndex;
        }
    }
}