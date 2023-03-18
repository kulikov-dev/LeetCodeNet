using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Easy.Trees
{
    /// <summary>
    /// https://leetcode.com/problems/symmetric-tree/
    /// </summary>
    /// <remarks> Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center). </remarks>
    internal sealed class SymmetricTree_101
    {
        /// <summary>
        /// Recursive solution
        /// </summary>
        /// <param name="root"> Root </param>
        /// <returns> Flag if symmetric </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public bool IsSymmetricRecursive(TreeNode root)
        {
            //// Entry point for a recursive solution
            return root != null && Recursive(root.left, root.right);
        }

        private bool Recursive(TreeNode nodeLeft, TreeNode nodeRight)
        {
            if (nodeLeft == null && nodeRight == null)
            {
                return true;
            }

            //// If value not equals - the tree is not symmetric
            if (nodeLeft?.val != nodeRight?.val)
            {
                return false;
            }

            //// Call recusive method with symmetric values left.left - right.right and left.right - right.left
            return Recursive(nodeLeft.left, nodeRight.right) && Recursive(nodeLeft.right, nodeRight.left);
        }

        /// <summary>
        /// Iterative solution with DFS approach
        /// </summary>
        /// <param name="root"> Root </param>
        /// <returns> Flag if symmetric </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public bool IsSymmetricIterative(TreeNode root)
        {
            if (root == null)
            {
                return false;
            }

            var stack = new Stack<TreeNode>();

            stack.Push(root.left);
            stack.Push(root.right);
            while (stack.Count > 0)
            {
                var left = stack.Pop();
                var right = stack.Pop();

                if (left?.val != right?.val)
                {
                    return false;
                }

                if (left == null || right == null)
                {
                    continue;
                }

                //// The same idea, but instead of calling recursive function - we put the symmetric elements in a stack
                stack.Push(left.left);
                stack.Push(right.right);

                stack.Push(left.right);
                stack.Push(right.left);
            }

            return true;
        }
    }
}