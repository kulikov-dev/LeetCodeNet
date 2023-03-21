using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Medium.Trees
{
    /// <summary>
    /// https://leetcode.com/problems/kth-largest-sum-in-a-binary-tree
    /// </summary>
    /// <remarks>
    /// You are given the root of a binary tree and a positive integer k.
    /// The level sum in the tree is the sum of the values of the nodes that are on the same level.
    /// Return the kth largest level sum in the tree (not necessarily distinct). If there are fewer than k levels in the tree, return -1.
    /// Note that two nodes are on the same level if they have the same distance from the root.
    /// </remarks>
    internal sealed class KthLargestSuminaBinaryTree_2583
    {
        /// <summary>
        /// Very straight forward solution. We go through the tree using BFS and calc sum on each level. Finally sort resulted list with sum's and get the k-th element
        /// </summary>
        /// <param name="root"> Tree root </param>
        /// <param name="k"> K-th largest level element </param>
        /// <returns> Element </returns>
        /// <remarks>
        /// Time complexity: O(n*log(n))
        /// Space complexity: O(n)
        /// </remarks>
        public long KthLargestLevelSum(TreeNode root, int k)
        {
            var queue = new Queue<TreeNode>();
            var sums = new List<long>();

            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var length = queue.Count;
                var sum = 0l;

                for (var i = 0; i < length; i++)
                {
                    var value = queue.Dequeue();

                    if (value == null)
                    {
                        continue;
                    }

                    sum += value.val;
                    queue.Enqueue(value.left);
                    queue.Enqueue(value.right);
                }

                sums.Add(sum);
            }

            if (k >= sums.Count)
            {
                return -1;
            }

            var sortedList = sums.OrderByDescending(x => x).ToArray();

            return sortedList[k - 1];
        }
    }
}
