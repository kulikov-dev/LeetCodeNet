using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Easy.Trees
{
    /// <summary>
    /// https://leetcode.com/problems/search-in-a-binary-search-tree/
    /// </summary>
    /// <remarks> Find the node in the BST that the node's value equals val and return the subtree rooted with that node. If such a node does not exist, return null. </remarks>
    public class SearchinaBinarySearchTree_700
    {
        /// <summary>
        /// Recursive solution
        /// </summary>
        /// <param name="root"> Root node </param>
        /// <param name="val"> Searchable value </param>
        /// <returns> Node with a searchable value or null </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public TreeNode SearchBSTRecursive(TreeNode root, int val)
        {
            if (root == null)
            {
                return null;
            }

            if (root.val == val)
            {
                return root;
            }

            //// As it is binary tree - we can choose child to go next
            return SearchBSTRecursive(val < root.val ? root.left : root.right, val);
        }

        /// <summary>
        /// Iterative solution
        /// </summary>
        /// <param name="root"> Root node </param>
        /// <param name="val"> Searchable value </param>
        /// <returns> Node with a searchable value or null </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public TreeNode SearchBSTIterative(TreeNode root, int val)
        {
            var node = root;
            while (node != null)
            {
                if (val == node.val)
                {
                    return node;
                }

                node = val < node.val ? node.left : node.right;
            }

            return null;
        }
    }
}
