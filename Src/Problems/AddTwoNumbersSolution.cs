using System.Numerics;

namespace LeetCode.Src.Problems
{
    /*
     * https://leetcode.com/problems/add-two-numbers/
     */
    internal class AddTwoNumbersSolution : Solution
    {
        public void Run()
        {
            Console.WriteLine("Number for first list = ?");
            ListNode firstList = ConvertNumberToList(int.Parse(Console.ReadLine()));
            Console.WriteLine("Number for second list = ?");
            ListNode secondList = ConvertNumberToList(int.Parse(Console.ReadLine()));
            Console.WriteLine(ConvertListToNumber(Solve(firstList, secondList)));
        }

        internal ListNode Solve(ListNode l1, ListNode l2)
        {
            int sum = 0;
            ListNode iterationNode = null, resultNode = null;
            while (l1 != null || l2 != null || sum != 0)
            {
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }
                if (iterationNode == null)
                    iterationNode = resultNode = new(sum % 10);
                else
                    iterationNode = iterationNode.next = new(sum % 10);
                sum /= 10;
            }
            return resultNode;
        }

        /* 
         * It is lazy solution using BigInteger.
         */
        internal ListNode SolveLazy(ListNode l1, ListNode l2)
        {
            BigInteger number1 = ConvertListToNumber(l1);
            BigInteger number2 = ConvertListToNumber(l2);
            return ConvertNumberToList(number1 + number2);
        }

        // Support methods.
        internal ListNode ConvertNumberToList(BigInteger number)
        {
            ListNode currentNode = new((int)(number % 10));
            if (number / 10 != 0)
            {
                currentNode.next = ConvertNumberToList(number / 10);
            }
            return currentNode;
        }

        internal BigInteger ConvertListToNumber(ListNode node)
        {
            if (node.next != null)
            {
                return ConvertListToNumber(node.next) * 10 + node.val;
            }
            return node.val;
        }

        internal class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}