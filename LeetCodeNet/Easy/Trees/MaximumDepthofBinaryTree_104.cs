using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Easy.Trees
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-depth-of-binary-tree/
    /// </summary>
    /// <remarks>
    /// Given the root of a binary tree, return its maximum depth.
    /// A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
    /// </remarks>
    internal sealed class MaximumDepthofBinaryTree_104
    {
        /// <summary>
        /// Recursive variant of BFS
        /// </summary>
        /// <param name="root"> Root </param>
        /// <returns> Maximum depth </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public int MaxDepthRecursive(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return Math.Max(MaxDepthRecursive(root.left), MaxDepthIterative(root.right)) + 1;
        }

        /// <summary>
        /// Iterative variant of BFS. Use queue to traverse through each level of a tree
        /// </summary>
        /// <param name="root"> Root </param>
        /// <returns> Maximum depth </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(h)
        /// </remarks>
        public int MaxDepthIterative(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var queue = new Queue<TreeNode>();
            var result = 0;

            queue.Enqueue(root);
            while (queue.Any())
            {
                ++result;
                var length = queue.Count;
                //// Iterate through nodes of a level
                for (var i = 0; i < length; ++i)
                {
                    var node = queue.Dequeue();

                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
            }

            return result;
        }
    }
}