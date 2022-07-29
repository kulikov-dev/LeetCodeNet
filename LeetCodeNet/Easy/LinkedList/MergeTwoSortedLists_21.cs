using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Easy.LinkedList
{
    /// <summary>
    /// https://leetcode.com/problems/merge-two-sorted-lists/
    /// </summary>
    /// <remarks>
    /// You are given the heads of two sorted linked lists list1 and list2.
    /// Merge the two lists in a one sorted list.The list should be made by splicing together the nodes of the first two lists.
    /// Return the head of the merged linked list.
    /// </remarks>
    public class MergeTwoSortedLists_21
    {
        /// <summary>
        /// Recreate tree using recursion approach
        /// The problem with recursion can be: https://en.wikipedia.org/wiki/Tail_call
        /// </summary>
        /// <param name="list1"> List 1 </param>
        /// <param name="list2"> List 2 </param>
        /// <returns> Head of the merged list </returns>
        /// <remarks>
        /// Time complexity: O(n+m), as we can have two different size lists, but need to iterate through each
        /// Space complexity: O(1)
        /// </remarks>
        public ListNode MergeTwoListsRecursive(ListNode list1, ListNode list2)
        {
            if (list1 == null)
            {
                return list2;
            }

            if (list2 == null)
            {
                return list1;
            }

            //// Compare values to keep sorting
            if (list1.val > list2.val)
            {
                list2.next = MergeTwoListsRecursive(list1, list2.next);
                return list2;
            }
            else
            {
                list1.next = MergeTwoListsRecursive(list1.next, list2);
                return list1;
            }
        }

        /// <summary>
        /// Iterative approach to prevent tail call
        /// </summary>
        /// <param name="list1"> List 1 </param>
        /// <param name="list2"> List 2 </param>
        /// <returns> Head of the merged list </returns>
        /// <remarks>
        /// Time complexity: O(n+m)
        /// Space complexity: O(1)
        /// </remarks>
        public ListNode MergeTwoListsIterative(ListNode list1, ListNode list2)
        {
            //// New head to return. Create fake one, to reduce null-check-conditions.
            var newHead = new ListNode(-1);
            var currentNode = newHead;
            while (list1 != null || list2 != null)
            {
                if (list1 == null)
                {
                    currentNode.next = list2;
                    list2 = list2.next;
                }
                else if (list2 == null)
                {
                    currentNode.next = list1;
                    list1 = list1.next;
                }
                else if (list1.val > list2.val)
                {
                    //// Compare values to keep sorting
                    currentNode.next = list2;
                    list2 = list2.next;
                }
                else
                {
                    currentNode.next = list1;
                    list1 = list1.next;
                }

                currentNode = currentNode.next;
            }

            return newHead.next;
        }
    }
}