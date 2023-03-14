using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Medium.Trees
{
    /// <summary>
    /// https://leetcode.com/problems/sum-root-to-leaf-numbers/
    /// </summary>
    /// <remarks>
    /// You are given the root of a binary tree containing digits from 0 to 9 only.
    /// Each root-to-leaf path in the tree represents a number.
    /// For example, the root-to-leaf path 1 -> 2 -> 3 represents the number 123.
    /// Return the total sum of all root-to-leaf numbers.Test cases are generated so that the answer will fit in a 32-bit integer.
    /// A leaf node is a node with no children.
    /// </remarks>
    public sealed class SumRootToLeafNumbers_129
    {
        /// <summary>
        /// It's a common depth-first search where we need to go through root to all leafs
        /// The fastest approach here is recursive solution (which I also recommend to use, as on the interview it will be fast and clear to explain the idea
        /// </summary>
        /// <param name="root"> Root </param>
        /// <returns> Sum of items </returns>
        public int SumNumbersRecursive(TreeNode root)
        {
            return Recursive(root, 0);
        }

        private int Recursive(TreeNode node, int sum)
        {
            if (node == null)
            {
                return 0;
            }

            var newValue = sum * 10 + node.val;

            if (node.left == null && node.right == null)
            {
                return newValue;
            }

            return Recursive(node.left, newValue) + Recursive(node.right, newValue);
        }

        /// <summary>
        /// The same approach but using stack with Tuple for storing intermediate number results. It's worth to say for the interviewer that instead of tuple we will use the struct for better readability
        /// </summary>
        /// <param name="root"> Root </param>
        /// <returns> Sum of items </returns>
        public int SumNumberDFS(TreeNode root)
        {
            var stack = new Stack<Tuple<TreeNode, int>>();

            stack.Push(new Tuple<TreeNode, int>(root, root.val));

            var total = 0;

            while (stack.Count > 0)
            {
                var node = stack.Pop();

                if (node.Item1.left == null && node.Item1.right == null)
                {
                    total += node.Item2;
                    continue;
                }

                if (node.Item1.left != null)
                {
                    stack.Push(new Tuple<TreeNode, int>(node.Item1.left, node.Item2 * 10 + node.Item1.left.val));
                }

                if (node.Item1.right != null)
                {
                    stack.Push(new Tuple<TreeNode, int>(node.Item1.right, node.Item2 * 10 + node.Item1.right.val));
                }
            }


            return total;
        }
    }
}
