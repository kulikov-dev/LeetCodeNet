using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Easy.Trees
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-inorder-traversal/
    /// </summary>
    /// <remarks> Inorder (Left, Root, Right) </remarks>
    internal sealed class BinaryTreeInorderTraversal_94
    {
        /// <summary>
        /// Inorder values in a recursive solution
        /// </summary>
        /// <param name="root"> Tree root </param>
        /// <returns> Inorder traversal </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public IList<int> InorderTraversalRecursive(TreeNode root)
        {
            var result = new List<int>();

            ProcessNodeRecursive(root, ref result);
            return result;
        }

        /// <summary>
        /// Helper function to work with a recursive solution
        /// </summary>
        /// <param name="node"> Tree node </param>
        /// <param name="result"> Inorder traversal </param>
        private void ProcessNodeRecursive(TreeNode node, ref List<int> result)
        {
            if (node == null)
            {
                return;
            }

            //// Traverse the left subtree
            ProcessNodeRecursive(node.left, ref result);
            //// Visit the root
            result.Add(node.val);
            //// Traverse the right subtree
            ProcessNodeRecursive(node.right, ref result);
        }

        /// <summary>
        /// Inorder values in a iterative solution
        /// </summary>
        /// <param name="root"> Tree root </param>
        /// <returns> Inorder traversal </returns>
        /// <remarks> We use stack, to go down to the most left node </remarks>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public IList<int> InorderTraverslIterative(TreeNode root)
        {
            var stack = new Stack<TreeNode>();
            var result = new List<int>();
            var nextNode = root;

            while (nextNode != null || stack.Any())
            {
                while (nextNode != null)
                {
                    //// Traverse the left subtree
                    stack.Push(nextNode);
                    nextNode = nextNode.left;
                }

                var node = stack.Pop();

                if (node == null)
                {
                    continue;
                }

                result.Add(node.val);
                //// Traverse the right subtree
                nextNode = node.right;
            }

            return result;
        }
    }
}