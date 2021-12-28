using System.Numerics;

using LeetCode.Src.Problems;

using NUnit.Framework;

using static LeetCode.Src.Problems.AddTwoNumbersSolution;

namespace LeetCode.Tests.Problems
{
    internal class AddTwoNumbersSolutionTests
    {
        [TestCase(342, 465, ExpectedResult = 807)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(9999999, 9999, ExpectedResult = 10009998)]
        public int SolveFitToIntTest(int number1, int number2)
        {
            // Arrange:
            AddTwoNumbersSolution solution = new();
            ListNode list1 = solution.ConvertNumberToList(number1);
            ListNode list2 = solution.ConvertNumberToList(number2);

            // Act:
            BigInteger result = solution.ConvertListToNumber(solution.Solve(list1, list2));

            // Assert:
            return (int)result;
        }

        [Test]
        public void Solve_BigIntegerInLists_ReturnSumAsList()
        {
            // Arrange:
            AddTwoNumbersSolution solution = new();
            ListNode list1 = solution.ConvertNumberToList(new BigInteger(99999999999999));
            ListNode list2 = solution.ConvertNumberToList(new BigInteger(11111111111111));
            ListNode expectedResult = solution.ConvertNumberToList(new BigInteger(111111111111110));

            // Act:
            ListNode result = solution.SolveLazy(list1, list2);

            // Assert:
            while (expectedResult != null || result != null)
            {
                Assert.AreEqual(expectedResult.val, result.val);
                expectedResult = expectedResult.next;
                result = result.next;
            }
            Assert.IsNull(expectedResult);
            Assert.IsNull(result);
        }

        [TestCase(342, 465, ExpectedResult = 807)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(9999999, 9999, ExpectedResult = 10009998)]
        public int SolveLazyFitToIntTest(int number1, int number2)
        {
            // Arrange:
            AddTwoNumbersSolution solution = new();
            ListNode list1 = solution.ConvertNumberToList(number1);
            ListNode list2 = solution.ConvertNumberToList(number2);

            // Act:
            BigInteger result = solution.ConvertListToNumber(solution.SolveLazy(list1, list2));

            // Assert:
            return (int)result;
        }

        [Test]
        public void SolveLazy_BigIntegerInLists_ReturnSumAsList()
        {
            // Arrange:
            AddTwoNumbersSolution solution = new();
            ListNode list1 = solution.ConvertNumberToList(new BigInteger(99999999999999));
            ListNode list2 = solution.ConvertNumberToList(new BigInteger(11111111111111));
            ListNode expectedResult = solution.ConvertNumberToList(new BigInteger(111111111111110));

            // Act:
            ListNode result = solution.SolveLazy(list1, list2);

            // Assert:
            while (expectedResult != null || result != null)
            {
                Assert.AreEqual(expectedResult.val, result.val);
                expectedResult = expectedResult.next;
                result = result.next;
            }
            Assert.IsNull(expectedResult);
            Assert.IsNull(result);
        }
    }
}
