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

        private bool Solve(int x)
        {
            if (x < 0) return false;

            int reverseX = 0;
            int duplicateX = x;
            while (duplicateX > 0)
            {
                reverseX = reverseX * 10 + duplicateX % 10;
                duplicateX /= 10;
            }
            return reverseX == x;
        }
    }
}