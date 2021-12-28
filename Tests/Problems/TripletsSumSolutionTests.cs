using System.Collections;
using System.Collections.Generic;

using LeetCode.Src.Problems;

using NUnit.Framework;

namespace LeetCode.Tests.Problems
{
    internal class TripletsSumSolutionTests
    {
        [TestCaseSource(typeof(TestCases))]
        public void SolveTest(List<int> nums, List<List<int>> expectedResult)
        {
            IList<IList<int>> result = new TripletsSumSolution().Solve(nums.ToArray());
            for (int i = 0; i < expectedResult.Count(); i++)
            {
                for (int j = 0; j < expectedResult.Count(); j++)
                {
                    CollectionAssert.AreEquivalent(expectedResult[i], result[i]);
                }
                Assert.AreEqual(expectedResult.Count(), result.Count());
            }
        }

        [TestCaseSource(typeof(TestCases))]
        public void SolveWithUseHashSetTest(List<int> nums, List<List<int>> expectedResult)
        {
            IList<IList<int>> result = new TripletsSumSolution().SolveWithUseHashSet(nums.ToArray());
            for (int i = 0; i < expectedResult.Count(); i++)
            {
                for (int j = 0; j < expectedResult.Count(); j++)
                {
                    CollectionAssert.AreEquivalent(expectedResult[i], result[i]);
                }
                Assert.AreEqual(expectedResult.Count(), result.Count());
            }
        }

        private class TestCases : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[]{  new List<int>() { -1, 0, 1, 2, -1, -4 },
                                            new List<List<int>>() { new List<int>() { -1, -1, 2 },
                                                                    new List<int>() { -1, 0, 1 } }};
                yield return new object[] { new List<int>(), new List<List<int>>() };
                yield return new object[] { new List<int>() { 0 }, new List<List<int>>() };
            }
        }
    }
}
