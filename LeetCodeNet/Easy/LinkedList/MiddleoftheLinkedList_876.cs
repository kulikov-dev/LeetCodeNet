using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Easy.LinkedList
{
    /// <summary>
    /// https://leetcode.com/problems/middle-of-the-linked-list/
    /// </summary>
    /// <remarks>
    /// Given the head of a singly linked list, return the middle node of the linked list.
    /// If there are two middle nodes, return the second middle node.
    /// </remarks>
    public class MiddleoftheLinkedList_876
    {
        /// <summary>
        /// Use slow/fast approach, where one pointer is moving slow (one step per iteration)
        /// And one pointer is moving fast (two steps per iteration)
        /// </summary>
        /// <param name="head"> Head of the list </param>
        /// <returns> Middle of the list </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public ListNode MiddleNode(ListNode head)
        {
            var slowPointer = head;
            var fastPointer = head;
            //// Find the middle with slow/fast pointers
            /// Slow (s), fast (f) pointers during the cycle:
            /// 1  2  3  4  5
            /// sf
            /// 1  2  3  4  5
            ///    s  f
            /// 1  2  3  4  5
            ///       s     f
            while (fastPointer != null && fastPointer.next != null)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next.next;
            }

            return slowPointer;
        }
    }
}