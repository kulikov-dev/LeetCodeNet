using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Easy.LinkedList
{
    /// <summary>
    /// https://leetcode.com/problems/remove-linked-list-elements/
    /// </summary>
    /// <remarks> Given the head of a linked list and an integer val, remove all the nodes of the linked list that has Node.val == val, and return the new head. </remarks>
    public sealed class RemoveLinkedListElements_203
    {
        /// <summary>
        /// Use two pointers to store a previous node and a current node in the list
        /// </summary>
        /// <param name="head"> Current head </param>
        /// <param name="val"> Value to remove </param>
        /// <returns> New head </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public ListNode RemoveElements(ListNode head, int val)
        {
            //// To short up the code - create a new fake head, so we don't need 'if new head is null than...'
            var newHead = new ListNode(-1) { next = head };
            var previousValue = newHead;
            var currentValue = newHead.next;
            while (currentValue != null)
            {
                //// Skip current node, if it's need to be removed
                if (currentValue.val == val)
                {
                    previousValue.next = currentValue.next;
                }
                else
                {
                    previousValue = currentValue;
                }

                //// Update link to the current node
                currentValue = currentValue.next;
            }

            return newHead.next;
        }
    }
}