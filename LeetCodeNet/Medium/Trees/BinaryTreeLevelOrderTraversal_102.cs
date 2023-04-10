using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Medium.Trees
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-level-order-traversal
    /// </summary>
    /// <remarks>
    /// Given the root of a binary tree, return the level order traversal of its nodes' values. (i.e., from left to right, level by level).
    /// </remarks>
    internal sealed class BinaryTreeLevelOrderTraversal_102
    {
        /// <summary>
        /// Use queue to process Breadth-First search.
        /// </summary>
        /// <param name="root"> Root </param>
        /// <returns> Tree values by levels </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(N)
        /// </remarks>
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var result = new List<List<int>>();
            var queue = new Queue<TreeNode>();

            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var count = queue.Count;
                var levelList = new List<int>();

                for (var i = 0; i < count; ++i)         //// Queue allows us to move through all nodes on the same level
                {
                    var node = queue.Dequeue();

                    if (node == null)
                    {
                        continue;
                    }

                    levelList.Add(node.val);
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }

                if (levelList.Count > 0)            //// Need to prevent adding the last level with all null nodes.
                {
                    result.Add(levelList);
                }
            }

            return result.ToArray();
        }
    }
}
