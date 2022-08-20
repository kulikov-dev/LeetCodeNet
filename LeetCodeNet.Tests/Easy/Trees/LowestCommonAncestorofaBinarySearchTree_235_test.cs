using LeetCodeNet.DataStructs;
using LeetCodeNet.Easy.Trees;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Trees
{
    public sealed class LowestCommonAncestorofaBinarySearchTree_235_test
    {
        [Theory, ClassData(typeof(LowestCommonAncestorofaBinarySearchTreeTestData))]
        public void CheckRecursive(TreeNode inputData1, TreeNode inputDataP, TreeNode inputDataQ, TreeNode expected)
        {
            var solver = new LowestCommonAncestorofaBinarySearchTree_235();
            var result = solver.LowestCommonAncestorRecursive(inputData1, inputDataP, inputDataQ);
            Assert.True(expected.val.Equals(result.val));
        }
    }

    public sealed class LowestCommonAncestorofaBinarySearchTreeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: The LCA of nodes 2 and 8 is 6.
            var sourceTree = new TreeNode(6, left: new TreeNode(2, left: new TreeNode(0), right: new TreeNode(4, left: new TreeNode(3), right: new TreeNode(5))), right: new TreeNode(8, new TreeNode(7), new TreeNode(9)));
            yield return new object[]
            {
                sourceTree,
                new TreeNode(2),
                new TreeNode(8),
                new TreeNode(6)
            };

            yield return new object[]
{
                sourceTree,
                new TreeNode(2),
                new TreeNode(4),
                new TreeNode(2)
};
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
