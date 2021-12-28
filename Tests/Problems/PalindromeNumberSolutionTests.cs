using LeetCode.Src.Problems;

using NUnit.Framework;

namespace LeetCode.Tests.Problems
{
    internal class PalindromeNumberSolutionTests
    {
        [TestCase(123, ExpectedResult = false)]
        [TestCase(0, ExpectedResult = true)]
        [TestCase(-121, ExpectedResult = false)]
        [TestCase(1, ExpectedResult = true)]
        [TestCase(21, ExpectedResult = false)]
        [TestCase(99, ExpectedResult = true)]
        [TestCase(10, ExpectedResult = false)]
        [TestCase(44554, ExpectedResult = false)]
        [TestCase(54554, ExpectedResult = false)]
        [TestCase(6767, ExpectedResult = false)]
        [TestCase(6776, ExpectedResult = true)]
        [TestCase(15551, ExpectedResult = true)]
        [TestCase(int.MaxValue, ExpectedResult = false)]
        [TestCase(int.MinValue, ExpectedResult = false)]
        public bool SolveTest(int x)
        {
            return new PalindromeNumberSolution().Solve(x);
        }
    }
}
