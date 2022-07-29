using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Easy.LinkedList
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-linked-list/
    /// </summary>
    /// <remarks>
    /// Given the head of a singly linked list, return true if it is a palindrome.
    /// More detailed explanation here: https://leetcode.com/problems/palindrome-linked-list/discuss/1137696/Short-and-Easy-w-Explanation-or-T-%3A-O(N)-S-%3A-O(1)-Solution-using-Fast-and-Slow
    /// </remarks>
    public class PalindromeLinkedList_234
    {
        /// <summary>
        /// 1. Find the middle of the list, using slow/fast pointers approach
        /// 2. All elements from 0 to middle will add to the stack
        /// 3. Move our slow pointer forward and compare values with nodes in the stack
        /// </summary>
        /// <param name="head"> Head </param>
        /// <returns> True, if palindrome </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n), as we need to store the Stack
        /// </remarks>
        public bool IsPalindromeStack(ListNode head)
        {
            var stack = new Stack<ListNode>();
            var slowPointer = head;
            var fastPointer = head;
            //// Find the middle with slow/fast pointers and also put all nodes from the first part of the list to the stack.
            /// Slow (s), fast (f) pointers during the cycle:
            /// 1  2  3  4  5
            /// sf
            /// 1  2  3  4  5
            ///    s  f
            /// 1  2  3  4  5
            ///       s     f
            while (fastPointer != null && fastPointer.next != null)
            {
                stack.Push(slowPointer);
                fastPointer = fastPointer.next?.next;
                slowPointer = slowPointer.next;
            }

            //// Process odd length lists, as we don't need to check the middle element: 1-3-1, so skip it (3).
            if (fastPointer != null)
            {
                slowPointer = slowPointer.next;
            }

            while (stack.Any())
            {
                if (stack.Pop().val != slowPointer.val)
                {
                    return false;
                }

                slowPointer = slowPointer.next;
            }

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public bool IsPalindromeReverse(ListNode head)
        {
            var slowPointer = head;
            var fastPointer = head;
            var reversedList = default(ListNode);
            while (fastPointer != null && fastPointer.next != null)
            {
                var temp = slowPointer.next;
                fastPointer = fastPointer.next?.next;
                slowPointer.next = reversedList;
                reversedList = slowPointer;
                slowPointer = temp;
            }

            if (fastPointer != null)
            {
                slowPointer = slowPointer.next;
            }

            while (reversedList != null)
            {
                if (reversedList.val != slowPointer.val)
                {
                    return false;
                }

                reversedList = reversedList.next;
                slowPointer = slowPointer.next;
            }

            return true;
        }
    }
}