namespace LeetCode.Src.Problems
{
    /*
     * https://leetcode.com/problems/reverse-integer/
     */
    internal class ReverseIntegerSolution : Solution
    {
        public void Run()
        {
            Console.WriteLine("X=?");
            Console.WriteLine(Solve(int.Parse(Console.ReadLine())));
        }

        internal int Solve(int x)
        {
            if (x == int.MinValue) return 0;

            bool isNegative = x < 0 ? true : false;
            x = Math.Abs(x);
            int reverseX = 0;
            while (x != 0)
            {
                if (reverseX > (int.MaxValue - x % 10) / 10)
                {
                    return 0;
                }
                reverseX = reverseX * 10 + x % 10;
                x /= 10;
            }
            return reverseX * (isNegative ? -1 : 1);
        }
    }
}