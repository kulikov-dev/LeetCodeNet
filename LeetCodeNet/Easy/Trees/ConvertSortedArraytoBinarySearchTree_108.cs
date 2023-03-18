using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Easy.Trees
{
    /// <summary>
    /// https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
    /// </summary>
    /// <remarks> Given an integer array nums where the elements are sorted in ascending order, convert it to a height-balanced binary search tree. </remarks>
    internal sealed class ConvertSortedArraytoBinarySearchTree_108
    {
        /// <summary>
        /// Ass we have a sorted array, we can use divide and conquer approach to get a middle and process it as a current node
        /// </summary>
        /// <param name="nums"> A sorted array </param>
        /// <returns> Binary search tree </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return FillSubTree(nums, 0, nums.Length - 1);
        }

        /// <summary>
        /// Recursive function
        /// </summary>
        /// <param name="nums"> Sorted array </param>
        /// <param name="leftIndex"> Left pointer </param>
        /// <param name="rightIndex"> Right pointer </param>
        /// <returns> Node with subree </returns>
        private TreeNode FillSubTree(int[] nums, int leftIndex, int rightIndex)
        {
            if (rightIndex < leftIndex)
            {
                return null;
            }

            //// Process the leafes
            if (rightIndex == leftIndex)
            {
                return new TreeNode(nums[leftIndex]);
            }

            var middleIndex = (int)(leftIndex + (rightIndex - leftIndex) * 0.5);
            var node = new TreeNode(nums[middleIndex])
            {
                //// Can divide array for two subarrays, which are smaller/bigger than a current value
                left = FillSubTree(nums, leftIndex, middleIndex - 1),
                right = FillSubTree(nums, middleIndex + 1, rightIndex)
            };

            return node;
        }
    }
}