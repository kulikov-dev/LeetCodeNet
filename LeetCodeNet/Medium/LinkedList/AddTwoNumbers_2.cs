using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Medium.LinkedList
{
    /// <summary>
    /// https://leetcode.com/problems/add-two-numbers
    /// </summary>
    /// <remarks>
    /// You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
    /// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
    /// </remarks>
    public sealed class AddTwoNumbers_2
    {
        /// <summary>
        /// Straight direct solution to check your knowledge of base structures like linked list. No specific things, just sum the numbers step by step and don't forget to keep in mind situation,
        /// when sum give more than 9.
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns>Sum of linked list</returns>
        /// <remarks>
        /// Time complexity:O(max(n,m))
        /// Space complexity: O(max(n,m))
        /// </remarks>
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var isTrailing = false;

            ListNode? head = null;
            ListNode? nextNode = null;

            while (l1 != null || l2 != null)
            {
                var num1 = l1?.val ?? 0;
                var num2 = l2?.val ?? 0;

                var sum = num1 + num2 + (isTrailing ? 1 : 0);
                isTrailing = false;

                if (sum > 9)
                {
                    isTrailing = true;
                    sum %= 10;
                }

                if (head == null)
                {
                    head = nextNode = new ListNode(sum);
                }
                else
                {
                    nextNode!.next = new ListNode(sum);
                    nextNode = nextNode.next;
                }

                l1 = l1?.next;
                l2 = l2?.next;
            }

            if (isTrailing)
            {
                nextNode.next = new ListNode(1);
            }

            return head;
        }
    }
}
