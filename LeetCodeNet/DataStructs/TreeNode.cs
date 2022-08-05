namespace LeetCodeNet.DataStructs
{
    /// <summary>
    /// Definition for a binary tree node.
    /// </summary>
    public class TreeNode
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
        /// Contructor with parameters
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
    }
}