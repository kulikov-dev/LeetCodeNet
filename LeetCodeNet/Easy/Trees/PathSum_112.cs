using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Easy.Trees
{
    /// <summary>
    /// https://leetcode.com/problems/path-sum/
    /// </summary>
    /// <remarks> Given the root of a binary tree and an integer targetSum, return true if the tree has a root-to-leaf path such that adding up all the values along the path equals targetSum. </remarks>
    public class PathSum_112
    {
        /// <summary>
        /// Recursive solution, BFS approach
        /// </summary>
        /// <param name="root"> Root node </param>
        /// <param name="targetSum"> Target sum </param>
        /// <returns> True, if contains target sum in Path </returns>
        /// <remarks>
        /// Time complexity: O(n), where N is the number of nodes in the given n-ary tree.
        /// Space complexity: O(1)
        /// </remarks>
        public bool HasPathSumRecursive(TreeNode root, int targetSum)
        {
            //// Wrong path
            if (root == null || targetSum < 0)
            {
                return false;
            }

            targetSum -= root.val;

            //// If current node is a leaf and target sum == 0 - it's Path
            if (root.left == null && root.right == null && targetSum == 0)
            {
                return true;
            }

            //// Check children with updated target sum
            return HasPathSumRecursive(root.left, targetSum) || HasPathSumRecursive(root.right, targetSum);
        }

        /// <summary>
        /// Use queue for iterative solution. 
        /// </summary>
        /// <param name="root"> Root node </param>
        /// <param name="targetSum"> Target sum </param>
        /// <returns> True, if contains target sum in Path </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public bool HasPathSumIterative(TreeNode root, int targetSum)
        {
            //// Check, if tree is not empty
            if (root == null)
            {
                return false;
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Any())
            {
                var length = queue.Count;
                for (var i = 0; i < length; ++i)
                {
                    var node = queue.Dequeue();

                    //// If current node is a leaf and target sum == 0 - it's Path
                    if (node.left == null && node.right == null && node.val == targetSum)
                    {
                        return true;
                    }

                    if (node.left != null)
                    {
                        //// Create new node for child with updated cumulative value
                        queue.Enqueue(new TreeNode(node.left.val + node.val, left: node.left.left, right: node.left.right));
                    }

                    if (node.right != null)
                    { 
                        //// Create new node for child with updated cumulative value
                        queue.Enqueue(new TreeNode(node.right.val + node.val, left: node.right.left, right: node.right.right));
                    }
                }
            }


            return false;
        }
    }
}
