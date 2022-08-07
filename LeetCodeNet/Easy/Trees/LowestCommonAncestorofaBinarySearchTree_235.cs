using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Easy.Trees
{
    /// <summary>
    /// https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/
    /// </summary>
    /// <remarks>
    /// Given a binary search tree (BST), find the lowest common ancestor (LCA) node of two given nodes in the BST.
    /// According to the definition of LCA on Wikipedia: “The lowest common ancestor is defined between two nodes p and q as the lowest node in T that has both p and q as descendants
    /// (where we allow a node to be a descendant of itself).”
    /// </remarks>
    public class LowestCommonAncestorofaBinarySearchTree_235
    {
        /// <summary>
        /// The key idea is that we have BINARY search tree. So, when we have p and q on different subtrees - that's the solution
        /// </summary>
        /// <param name="root"> Root </param>
        /// <param name="p"> P node </param>
        /// <param name="q"> Q node </param>
        /// <returns> Lowest common ancestor </returns>
        public TreeNode LowestCommonAncestorRecursive(TreeNode root, TreeNode p, TreeNode q)
        {
            if ((p.val <= root.val && q.val >= root.val) || (q.val <= root.val && p.val >= root.val))
            {
                return root;
            }

            if (p.val > root.val)
            {
                return LowestCommonAncestorRecursive(root.right, p, q);
            }
            else
            {
                return LowestCommonAncestorRecursive(root.left, p, q);
            }
        }
    }
}