using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Easy.LinkedList
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-linked-list/
    /// </summary>
    /// <remarks> Given the head of a singly linked list, reverse the list, and return the reversed list. </remarks>
    internal sealed class ReverseLinkedList_206
    {
        /// <summary>
        /// 1. Create a new head
        /// 2. Update all pointers to the next element in the reverse order
        /// </summary>
        /// <param name="head"> Current head </param>
        /// <returns> New head </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public ListNode ReverseList(ListNode head)
        {
            var newHead = default(ListNode);

            while (head != null)
            {
                var temp = newHead;
                newHead = new ListNode(head.val) { next = temp };
                head = head.next;
            }

            return newHead;
        }
    }
}