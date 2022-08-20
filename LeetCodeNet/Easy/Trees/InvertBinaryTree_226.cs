using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Easy.Trees
{
    /// <summary>
    /// https://leetcode.com/problems/invert-binary-tree/
    /// </summary>
    /// <remarks> Given the root of a binary tree, invert the tree, and return its root. </remarks>
    public sealed class InvertBinaryTree_226
    {
        /// <summary>
        /// Go recursive through each child of the tree and invert left/right children
        /// </summary>
        /// <param name="root"> Root of the tree </param>
        /// <returns> Root of the inverted tree </returns>
        /// <remarks>
        /// Time complexity: O(H), height of the tree
        /// Space complexity: O(1)
        /// </remarks>
        public TreeNode InvertTreeRecursive(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            var tempNode = root.left;
            root.left = root.right;
            root.right = tempNode;
            InvertTreeRecursive(root.left);
            InvertTreeRecursive(root.right);
            return root;
        }

        /// <summary>
        /// Use BFS and queue to process inverting iteratively
        /// </summary>
        /// <param name="root"> Root of the tree </param>
        /// <returns> Root of the inverted tree </returns>
        /// <remarks>
        /// Time complexity: O(H), height of the tree
        /// Space complexity: O(1)
        /// </remarks>
        public TreeNode InvertTreeIterative(TreeNode root)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (node == null)
                {
                    continue;
                }

                var tempNode = node.left;
                node.left = node.right;
                node.right = tempNode;

                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
            }

            return root;
        }
    }
}