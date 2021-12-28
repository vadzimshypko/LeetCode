namespace LeetCode.Src.Problems
{
    /*
     * https://leetcode.com/problems/jump-game/
     */
    internal class JumpGameSolution : Solution
    {
        public void Run()
        {
            Console.WriteLine("Nums=?,?,?");
            int[] nums = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            Console.WriteLine(Solve(nums));
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