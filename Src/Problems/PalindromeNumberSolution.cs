namespace LeetCode.Src.Problems
{
    /*
     * https://leetcode.com/problems/palindrome-number/
     */
    internal class PalindromeNumberSolution : Solution
    {
        public void Run()
        {
            Console.WriteLine("X=?");
            Console.WriteLine(Solve(int.Parse(Console.ReadLine())));
        }

        internal bool Solve(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0)) return false;

            int revertedX = 0;
            while (x > revertedX)
            {
                revertedX = revertedX * 10 + x % 10;
                x /= 10;
            }
            return revertedX == x || x == revertedX / 10;
        }
    }
}