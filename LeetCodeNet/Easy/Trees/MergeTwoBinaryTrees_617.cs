using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Easy.Trees
{
    /// <summary>
    /// https://leetcode.com/problems/merge-two-binary-trees/
    /// </summary>
    /// <remarks>
    /// Imagine that when you put one of them to cover the other, some nodes of the two trees are overlapped while the others are not. 
    /// You need to merge the two trees into a new binary tree. The merge rule is that if two nodes overlap, then sum node values up as the new value of the merged node. 
    /// Otherwise, the NOT null node will be used as the node of the new tree.
    /// Return the merged tree.
    /// </remarks>
    public class MergeTwoBinaryTrees_617
    {
        /// <summary>
        /// Another variant of BFS. Move level by level and change values
        /// </summary>
        /// <param name="root1"> Root 1 </param>
        /// <param name="root2"> Root 2 </param>
        /// <returns> A merged tree root </returns>
        /// <remarks>
        /// Time complexity: O(m)
        /// Space complexity: O(m)
        /// </remarks>
        public TreeNode MergeTreesRecursive(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null)
            {
                return null;
            }

            var value1 = root1?.val ?? 0;
            var value2 = root2?.val ?? 0;
            //// We don't change the source trees, as it is a bad practise
            var newRoot = new TreeNode(value1 + value2)
            {
                left = MergeTreesRecursive(root1?.left, root2?.left),
                right = MergeTreesRecursive(root1?.right, root2?.right)
            };

            return newRoot;
        }
    }
}