using LeetCode.Src.Problems;

using NUnit.Framework;

namespace LeetCode.Tests.Problems
{
    internal class TwoSumSolutionTests
    {
        [TestCase(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [TestCase(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
        [TestCase(new[] { 3, 3 }, 6, new[] { 0, 1 })]
        public void SolveTest(int[] nums, int target, int[] expectedResult)
        {
            int[] result = new TwoSumSolution().Solve(nums, target);
            Array.Sort(result);
            Array.Sort(expectedResult);
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], result[i]);
            }
            Assert.AreEqual(expectedResult.Length, result.Length);
        }
    }
}
