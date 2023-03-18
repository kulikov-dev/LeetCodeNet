using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Medium.Trees
{
    /// <summary>
    /// https://leetcode.com/problems/validate-binary-search-tree/
    /// </summary>
    /// <remarks>
    /// Given the root of a binary tree, determine if it is a valid binary search tree (BST).
    /// A valid BST is defined as follows:
    /// The left subtree of a node contains only nodes with keys less than the node's key.
    /// The right subtree of a node contains only nodes with keys greater than the node's key.
    /// Both the left and right subtrees must also be binary search trees.
    /// </remarks>
    internal sealed class ValidateBinarySearchTree_98
    {
        /// <summary>
        /// We need to assure that all values from the left subtree a lower than root and all valies from the right subtree a higher than root
        /// So, we can pass min/max values into the recursive function for checking. The trick here is to correctly pass the arguments for the left and the right subtree
        /// </summary>
        /// <param name="root"> Root </param>
        /// <returns> True, if BST </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public bool IsValidBST(TreeNode root)
        {
            return Recursive(root, long.MinValue, long.MaxValue);
        }

        /// <summary>
        /// Recursive checker
        /// </summary>
        /// <param name="root"> Node </param>
        /// <param name="min">Total min for subtree </param>
        /// <param name="max"> Total max for subtree </param>
        /// <returns> True, if BST </returns>
        public bool Recursive(TreeNode root, long min, long max)
        {
            if (root == null)
            {
                return true;
            }

            if (root.val >= max || root.val <= min)
            {
                return false;
            }

            return Recursive(root.left, min, root.val) && Recursive(root.right, root.val, max);
        }
    }
}
