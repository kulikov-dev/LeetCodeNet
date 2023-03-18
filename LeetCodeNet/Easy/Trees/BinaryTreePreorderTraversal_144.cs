using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Easy.Trees
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-preorder-traversal/
    /// </summary>
    /// <remarks> Preorder (Root, Left, Right)  </remarks>
    internal sealed class BinaryTreePreorderTraversal_144
    {
        /// <summary>
        /// Preorder values in a recursive solution
        /// </summary>
        /// <param name="root"> Tree root </param>
        /// <returns> Preorder traversal </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public IList<int> PreorderTraversalRecurssive(TreeNode root)
        {
            var result = new List<int>();

            ProcessNodeRecursive(root, ref result);
            return result;
        }

        /// <summary>
        /// Helper function to work with a recursive solution
        /// </summary>
        /// <param name="node"> Tree node </param>
        /// <param name="result"> Postorder traversal </param>
        private void ProcessNodeRecursive(TreeNode node, ref List<int> result)
        {
            if (node == null)
            {
                return;
            }

            //// Visit the root
            result.Add(node.val);
            //// Traverse the left subtree
            ProcessNodeRecursive(node.left, ref result);
            //// Traverse the right subtree
            ProcessNodeRecursive(node.right, ref result);
        }

        /// <summary>
        /// Preorder values in a iterative solution
        /// </summary>
        /// <param name="root"> Tree root </param>
        /// <returns> Preorder traversal </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public IList<int> PreorderTraversalIterative(TreeNode root)
        {
            var stack = new Stack<TreeNode>();
            var result = new List<int>();

            stack.Push(root);
            while (stack.Any())
            {
                var node = stack.Pop();

                if (node == null)
                {
                    continue;
                }

                //// Visit the root
                result.Add(node.val);

                //// Traverse the right subtree
                stack.Push(node.right);

                //// Traverse the left subtree (back order because of the stack)
                stack.Push(node.left);
            }

            return result;
        }
    }
}