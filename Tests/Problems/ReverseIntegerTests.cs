using NUnit.Framework;

namespace LeetCode.Tests.Problems
{
    internal class ReverseIntegerTests
    {
        [Test]
        public void Solve_Reverting123_Returns321()
        {
            // Arrange:
            int x = 123;
            ReverseIntegerSolution reverseIntegerSolver = new();

            // Act:
            int result = reverseIntegerSolver.Solve(x);

            // Assert:
            Assert.AreEqual(321, result);
        }

        [TestCase(5555, ExpectedResult = 5555)]
        [TestCase(-1234566, ExpectedResult = -6654321)]
        [TestCase(120, ExpectedResult = 21)]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(-2147483648, ExpectedResult = 0)]
        [TestCase(-2147483647, ExpectedResult = 0)]
        public int SolveTest(int x)
        {
            return new ReverseIntegerSolution().Solve(x);
        }
    }
}
