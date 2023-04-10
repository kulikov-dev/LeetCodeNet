using System.Collections;
using LeetCodeNet.DataStructs;
using LeetCodeNet.Medium.Trees;

namespace LeetCodeNet.Tests.Medium.Trees
{
    public sealed class BinaryTreeLevelOrderTraversal_102_test
    {
        [Theory, ClassData(typeof(BinaryTreeLevelOrderTraversalTestData))]
        public void Check(TreeNode input, List<List<int>> expected)
        {
            var solver = new BinaryTreeLevelOrderTraversal_102();
            var result = solver.LevelOrder(input);

            Assert.Equal(expected.Count, result.Count);

            for (var i = 0; i < expected.Count; i++)
            {
                Assert.True(expected[i].SequenceEqual(result[i]));
            }
        }
    }

    public sealed class BinaryTreeLevelOrderTraversalTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7))),
                new List<List<int>> {new() {3}, new() {9, 20}, new() {15,7}}
            };

            yield return new object[]
            {
                new TreeNode(1),
                new List<List<int>> {new() {1}}
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
