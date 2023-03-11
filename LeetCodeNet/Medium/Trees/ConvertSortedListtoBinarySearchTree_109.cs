using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Medium.Trees
{
    /// <summary>
    /// https://leetcode.com/problems/convert-sorted-list-to-binary-search-tree
    /// </summary>
    /// <remarks> Given the head of a singly linked list where elements are sorted in ascending order, convert it to a height-balanced binary search tree. </remarks>
    public sealed class ConvertSortedListtoBinarySearchTree_109
    {
        /// <summary>
        /// The first step is understanding the problem.
        /// As we have already sorted list, we can use divide and conquer approach. For easy understanding (and at least provide any solution)
        /// We can first run through more easy and understandable solution which require more space for converting linked list to the array.
        /// </summary>
        /// <param name="head"> Linked list head </param>
        /// <returns> BST tree </returns>
        /// <remarks>
        /// Time complexity:O(n*log(n))
        /// Space complexity: O(n)
        /// </remarks>
        public TreeNode SortedListToBSTEasy(ListNode head)
        {
            var data = new List<int>();

            while (head != null)
            {
                data.Add(head.val);

                head = head.next;
            }

            var result = RecursiveArray(data, 0, data.Count - 1);

            return result;
        }

        /// <summary>
        /// Recursive function to iterate through array and fill BST
        /// </summary>
        /// <param name="data"> Input array </param>
        /// <param name="leftIndex"> Current left index for D&C approach </param>
        /// <param name="rightIndex"> Current right index for D&C approach </param>
        /// <returns> Current head of the tree </returns>
        private TreeNode RecursiveArray(List<int> data, int leftIndex, int rightIndex)
        {
            if (leftIndex > rightIndex)
            {
                return null;
            }

            var middleIndex = leftIndex + (rightIndex - leftIndex) / 2;
            var node = new TreeNode(data[middleIndex])
            {
                left = RecursiveArray(data, leftIndex, middleIndex - 1),
                right = RecursiveArray(data, middleIndex + 1, rightIndex)
            };

            return node;
        }


        /// <summary>
        /// Based on the previous approach we can transform our solution to O(1) space complexity without using array and iterate directly through the linked list
        /// We can apply here the same divide and conquer approach + two pointers (slow/fast) for iterating.
        /// </summary>
        /// <param name="head"> Linked list head </param>
        /// <returns> BST tree </returns>
        /// <remarks>
        /// Time complexity:O(n*log(n))
        /// Space complexity: O(1)
        /// </remarks>
        public TreeNode SortedListToBSTOptimal(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            var result = Recreate(head, null);

            return result;
        }

        private TreeNode Recreate(ListNode head, ListNode tail)
        {
            if (head == tail)
            {
                return null;
            }

            var slow = head;
            var fast = head;
            while (fast != tail && fast.next != tail)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            var result = new TreeNode(slow.val);
            result.left = Recreate(head, slow);
            result.right = Recreate(slow.next, tail);

            return result;
        }
    }
}
