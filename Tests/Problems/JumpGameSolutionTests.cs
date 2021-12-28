using LeetCode.Src.Problems;

using NUnit.Framework;

namespace LeetCode.Tests.Problems
{
    internal class JumpGameSolutionTests
    {
        [TestCase(new[] { 2, 3, 1, 1, 4 }, ExpectedResult = true)]
        [TestCase(new[] { 3, 2, 1, 0, 4 }, ExpectedResult = false)]
        [TestCase(new[] { 4, 0, 0, 0, 4 }, ExpectedResult = true)]
        [TestCase(new[] { 1, 1, 1, 1, 4 }, ExpectedResult = true)]
        [TestCase(new[] { 1, 2, 0, 1, 4 }, ExpectedResult = true)]
        [TestCase(new[] { 4 }, ExpectedResult = true)]
        [TestCase(new[] { 0, 1 }, ExpectedResult = false)]
        [TestCase(new[] { 0 }, ExpectedResult = true)]
        [TestCase(new[] { 1, 1 }, ExpectedResult = true)]
        public bool SolveTest(int[] nums)
        {
            return new JumpGameSolution().Solve(nums);
        }
    }
}
