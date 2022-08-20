using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Easy.LinkedList
{
    /// <summary>
    /// https://leetcode.com/problems/linked-list-cycle/
    /// </summary>
    /// <remarks>
    /// Given head, the head of a linked list, determine if the linked list has a cycle in it.
    /// There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer.
    /// Internally, pos is used to denote the index of the node that tail's next pointer is connected to. Note that pos is not passed as a parameter.
    /// </remarks>
    public sealed class LinkedListCycle_141
    {
        /// <summary>
        /// Two pointers approach, where one is moving faster, than another.
        /// </summary>
        /// <param name="head"> Head of the list </param>
        /// <returns> True, if linked list is cycled </returns>
        /// <remarks>
        /// Time complexity: O(n), to iterate through linked list
        /// Space complexity: O(1)
        /// </remarks>
        public bool HasCycle(ListNode head)
        {
            var fastPointer = head;
            var slowPointer = head;
            while (fastPointer != null)
            {
                slowPointer = slowPointer?.next;
                fastPointer = fastPointer?.next?.next;
                //// Check, if two pointers are equal - the cycle is found
                if (slowPointer != null && slowPointer == fastPointer)
                {
                    return true;
                }
            }

            //// In this case, we found an end of the linked list
            return false;
        }
    }
}
