namespace LeetCode.Src.Problems
{
    /*
     * https://leetcode.com/problems/swap-nodes-in-pairs/
     */
    internal class SwapNodesInPairs : Solution
    {       
        public void Run()
        {
            Console.WriteLine("Head=?,?,?");
            int[] inputArray = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            ListNode result = Solve(ConvertArrayToListNodes(inputArray));
            while (result != null)
            {
                Console.Write(result.val + " ");
                result = result.next;
            }
            Console.Write("\n");
        }

        internal ListNode Solve(ListNode head)
        {
            ListNode mockHead = new ListNode();
            mockHead.next = head;
            ListNode prevNode = mockHead, firstNode, secondNode, nextNode;
            while (prevNode?.next != null && prevNode?.next?.next != null)
            {
                firstNode = prevNode.next;
                secondNode = firstNode.next;
                nextNode = secondNode.next;

                prevNode.next = secondNode;
                secondNode.next = firstNode;
                firstNode.next = nextNode;

                prevNode = firstNode;
            }
            return mockHead.next;
        }

        internal ListNode? ConvertArrayToListNodes(int[] inputArray)
        {
            if (inputArray == null || inputArray.Length == 0) return null;

            ListNode head = new ListNode(inputArray[0]);
            if (inputArray.Length == 1) return head;

            ListNode lastNode = head.next = new ListNode(inputArray[1]);
            for (int i = 2; i < inputArray.Length; i++)
            {
                lastNode = lastNode.next = new ListNode(inputArray[i]);
            }
            return head;
        }

        public class ListNode
        {
            public readonly int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
