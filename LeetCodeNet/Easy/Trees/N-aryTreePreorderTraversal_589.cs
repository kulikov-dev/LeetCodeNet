using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Easy.Trees
{
    /// <summary>
    /// https://leetcode.com/problems/n-ary-tree-preorder-traversal/
    /// </summary>
    /// <remarks> Given the root of an n-ary tree, return the preorder traversal of its nodes' values. </remarks>
    internal sealed class N_aryTreePreorderTraversal_589
    {
        /// <summary>
        /// Recursive solution. Call recursive void for an each child to build preorder traversal
        /// </summary>
        /// <param name="root"> Root node </param>
        /// <returns> List of values in preorder </returns>
        /// <remarks>
        /// Time complexity: O(n), where N is the number of nodes in the given n-ary tree.
        /// Space complexity: O(n), the max recursive depth
        /// </remarks>
        public IList<int> PreorderRecursive(NaryTreeNode root)
        {
            var result = new List<int>();

            RecursiveVoid(root, ref result);
            return result;
        }

        /// <summary>
        /// Helper void for a recursive solution
        /// </summary>
        /// <param name="node"> Node </param>
        /// <param name="result"> Result </param>
        private void RecursiveVoid(NaryTreeNode? node, ref List<int> result)
        {
            if (node == null)
            {
                return;
            }

            result.Add(node.val);
            if (node.children != null)
            {
                foreach (var child in node.children)
                {
                    RecursiveVoid(child, ref result);
                }
            }
        }

        /// <summary>
        /// Use stack for an iterative solution
        /// </summary>
        /// <param name="root"> Root node </param>
        /// <returns> List of values in preorder </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        /// Time complexity: O(m)
        /// Space complexity: O(m)
        /// </remarks>
        public IList<int> PreorderIterative(NaryTreeNode root)
        {
            var result = new List<int>();
            var stack = new Stack<NaryTreeNode?>();

            stack.Push(root);
            while (stack.Count > 0)
            {
                var node = stack.Pop();

                if (node == null)
                {
                    continue;
                }

                result.Add(node.val);
                if (node.children == null)
                {
                    continue;
                }

                //// As the structure is stack - we iterate through children in reverse order
                /// So the left node will pop first as LIFO
                for (var i = node.children.Count - 1; i >= 0; i--)
                {
                    stack.Push(node.children[i]);
                }
            }

            return result;
        }
    }
}