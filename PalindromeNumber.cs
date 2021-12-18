using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * https://leetcode.com/problems/palindrome-number/
 */
namespace LeetCode
{
    internal class PalindromeNumber : Solution
    {
        public void Run()
        {
            Console.WriteLine("X = ?");
            Console.WriteLine(Solve(int.Parse(Console.ReadLine())));
        }

        public void RunWithDefaultArguments()
        {
            Console.WriteLine(Solve(121));
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
