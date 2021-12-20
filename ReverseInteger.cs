namespace LeetCode
{
    /**
     * https://leetcode.com/problems/reverse-integer/
     */
    internal class ReverseInteger : Solution
    {
        public void Run()
        {
            Console.WriteLine("X = ?");
            Console.WriteLine(Solve(int.Parse(Console.ReadLine())));
        }

        public void RunWithDefaultArguments()
        {
            Console.WriteLine(Solve(1534236469));
        }

        private int Solve(int x)
        {
            bool isNegative = x < 0 ? true : false;
            x *= isNegative ? -1 : 1;
            int reverseX = 0;
            while(x != 0)
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