using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Easy.Trees
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-postorder-traversal/
    /// </summary>
    /// <remarks> Postorder (Left, Right, Root)  </remarks>
    internal sealed class BinaryTreePostorderTraversal_145
    {
        /// <summary>
        /// Postorder values in a recursive solution
        /// </summary>
        /// <param name="root"> Tree root </param>
        /// <returns> Postorder traversal </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public IList<int> PostorderTraversalRecurssive(TreeNode root)
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

            //// Traverse the left subtree
            ProcessNodeRecursive(node.left, ref result);
            //// Traverse the right subtree
            ProcessNodeRecursive(node.right, ref result);
            //// Visit the root
            result.Add(node.val);
        }

        /// <summary>
        /// Postorder values in a iterative solution
        /// </summary>
        /// <param name="root"> Tree root </param>
        /// <returns> Postorder traversal </returns>
        /// <remarks> Make BFS from top to bottom and then reverse it </remarks>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public IList<int> PostorderTraversalIterative(TreeNode root)
        {
            var stack = new Stack<TreeNode>();
            var result = new List<int>();

            stack.Push(root);
            while (stack.Any())
            {
                var count = stack.Count;

                for (var i = 0; i < count; ++i)
                {
                    var node = stack.Pop();

                    if (node == null)
                    {
                        continue;
                    }

                    result.Add(node.val);
                    stack.Push(node.left);
                    stack.Push(node.right);
                }
            }

            result.Reverse();
            return result;
        }
    }
}
