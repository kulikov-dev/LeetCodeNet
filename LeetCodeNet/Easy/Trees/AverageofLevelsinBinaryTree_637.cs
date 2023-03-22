using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Easy.Trees
{
    /// <summary>
    /// https://leetcode.com/problems/average-of-levels-in-binary-tree/
    /// </summary>
    /// <remarks>
    /// Given the root of a binary tree, return the average value of the nodes on each level in the form of an array. Answers within 10-5 of the actual answer will be accepted.
    /// </remarks>
    internal sealed class AverageofLevelsinBinaryTree_637
    {
        /// <summary>
        /// Iterative variant of BFS. Use queue to traverse through each level of a tree
        /// </summary>
        /// <param name="root"> Root </param>
        /// <returns> Average values </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(h)
        /// </remarks>
        public IList<double> AverageOfLevels(TreeNode root)
        {
            var result = new List<double>();
            var queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var sum = 0d;
                var length = queue.Count;

                for (var i = 0; i < length; i++)
                {
                    var node = queue.Dequeue();

                    sum += node.val;
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }

                result.Add(sum / length);
            }

            return result;
        }
    }
}
