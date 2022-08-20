using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Easy.Trees
{
    /// <summary>
    /// https://leetcode.com/problems/sum-of-left-leaves/
    /// </summary>
    /// <remarks> Given the root of a binary tree, return the sum of all left leaves. A leaf is a node with no children. A left leaf is a leaf that is the left child of another node. </remarks>
    public sealed class SumofLeftLeaves_404
    {
        /// <summary>
        /// Recursive solution
        /// </summary>
        /// <param name="root"> Root node </param>
        /// <returns> Sum of left leaves </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public int SumOfLeftLeavesRecursive(TreeNode root)
        {
            var result = 0;
            if (root == null)
            {
                return result;
            }

            //// Check if we have left child and it is a leaf - add to sum
            if (root.left != null && root.left.left == null && root.left.right == null)
            {
                result += root.left.val;
            }

            //// Check left and right children recursive
            return SumOfLeftLeavesRecursive(root.left) + SumOfLeftLeavesRecursive(root.right) + result;
        }

        /// <summary>
        /// Iterative BFS solution
        /// </summary>
        /// <param name="root"> Root node </param>
        /// <returns> Sum of left leaves </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(N)
        /// </remarks>
        public int SumOfLeftLeavesIterative(TreeNode root)
        {
            var result = 0;

            //// It's not important, we can use both: BFS or DFS solutions
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (node == null)
                {
                    continue;
                }
                
                //// The same approach
                if (node.left != null && node.left.left == null && node.left.right == null)
                {
                    result += node.left.val;
                }
                else
                {
                    queue.Enqueue(node.left);
                }

                queue.Enqueue(node.right);
            }

            return result;
        }
    }
}