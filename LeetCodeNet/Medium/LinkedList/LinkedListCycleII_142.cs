using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Medium.LinkedList
{
    /// <summary>
    /// https://leetcode.com/problems/linked-list-cycle-ii
    /// </summary>
    /// <remarks>
    /// Given the head of a linked list, return the node where the cycle begins. If there is no cycle, return null.
    /// There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer.
    /// Internally, pos is used to denote the index of the node that tail's next pointer is connected to (0-indexed). It is -1 if there is no cycle. Note that pos is not passed as a parameter.
    /// Do not modify the linked list.
    /// </remarks>
    internal sealed class LinkedListCycleII_142
    {
        /// <summary>
        /// The solution for this problem is contains in combing two approaches:
        /// Step 1. We need to detect if any loops are here. For this we will use slow/fast pointers approach.
        /// Where we have slow pointer which move to the next element and fast pointer which move to the next-next element
        /// But after that we still need to detect the start of this loop.
        /// Step 2. Detect the start of the loop. For this we can use Floyd's cycle detection algorithm.
        /// The great explanation can be founded here: https://www.youtube.com/watch?v=zbozWoMgKW0
        /// </summary>
        /// <param name="head"> Head </param>
        /// <returns> Start cycle node </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(N)
        /// </remarks>
        public ListNode DetectCycle(ListNode head)
        {
            var slow = head;
            var fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    var entryCycleNode = head;

                    while (slow != entryCycleNode)
                    {
                        slow = slow.next;
                        entryCycleNode = entryCycleNode.next;
                    }

                    return entryCycleNode;
                }
            }

            return null;
        }
    }
}
