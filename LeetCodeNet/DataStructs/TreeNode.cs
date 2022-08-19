namespace LeetCodeNet.DataStructs
{
    /// <summary>
    /// Definition for a binary tree node.
    /// </summary>
    public class TreeNode : IEquatable<TreeNode>
    {
        /// <summary>
        /// Value
        /// </summary>
        public int val;

        /// <summary>
        /// Left node
        /// </summary>
        public TreeNode left;

        /// <summary>
        /// Right node
        /// </summary>
        public TreeNode right;

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="val"> Value </param>
        /// <param name="left"> Left node </param>
        /// <param name="right"> Right node </param>
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        /// <summary>
        /// Equal tree's by values
        /// </summary>
        /// <param name="node2"> Second tree root </param>
        /// <returns> Tree's are equal </returns>
        public bool Equals(TreeNode? other)
        {
            var tree1 = this;
            var tree2 = other;

            if (!tree1.val.Equals(tree2?.val))
            {
                return false;
            }

            var isLeftEqual = (tree1.left == null && tree2.left == null) || (tree1.left.Equals(tree2.left));
            var isRightEqual = (tree1.right == null && tree2.right == null) || (tree1.right.Equals(tree2.right));
            return isLeftEqual && isRightEqual;
        }
    }
}