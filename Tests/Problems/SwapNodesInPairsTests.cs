using LeetCode.Src.Problems;

using NUnit.Framework;

namespace LeetCode.Tests.Problems
{
    internal class SwapNodesInPairsTests
    {
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 2, 1, 4, 3 })]
        [TestCase(new int[] { 3 }, new int[] { 3 })]
        [TestCase(new int[] { 3, 4, 5, 6, 7 }, new int[] { 4, 3, 6, 5, 7 })]
        [TestCase(new int[] { }, new int[] { })]
        public void SolveTest(int[] input, int[] expectedResult)
        {
            SwapNodesInPairs solution = new();
            SwapNodesInPairs.ListNode headNode = solution.ConvertArrayToListNodes(input);
            headNode = solution.Solve(headNode);
            Assert.AreEqual(ConvertNodeToList(headNode), new List<int>(expectedResult));
        }

        private List<int> ConvertNodeToList(SwapNodesInPairs.ListNode head)
        {
            List<int> result = new();
            while (head != null)
            {
                result.Add(head.val);
                head = head.next;
            }
            return result;
        }
    }
}
