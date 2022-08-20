using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Easy.LinkedList
{
    /// <summary>
    /// https://leetcode.com/problems/remove-duplicates-from-sorted-list/
    /// </summary>
    /// <remarks> Given the head of a sorted linked list, delete all duplicates such that each element appears only once. Return the linked list sorted as well. </remarks>
    public sealed class RemoveDuplicatesfromSortedList_83
    {
        /// <summary>
        /// Use two pointers to store a previous node and a current node in the list
        /// </summary>
        /// <param name="head"> Old head </param>
        /// <returns> New head </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public ListNode DeleteDuplicatesIterative(ListNode head)
        {
            var previousNode = head;
            var currentNode = head?.next;
            while (currentNode != null)
            {
                if (currentNode.val == previousNode.val)
                {
                    currentNode = currentNode.next;
                    previousNode.next = currentNode;
                }
                else
                {
                    previousNode = currentNode;
                    currentNode = currentNode.next;
                }
            }

            return head;
        }

        /// <summary>
        /// We can put the previous solution to recursive way, which will be much shorter
        /// </summary>
        /// <param name="head"> Old head </param>
        /// <returns> New head </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public ListNode DeleteDuplicatesRecursive(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            head.next = DeleteDuplicatesRecursive(head.next);
            return head.val == head.next.val ? head.next : head;
        }
    }
}