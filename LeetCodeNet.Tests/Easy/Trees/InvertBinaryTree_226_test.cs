using LeetCodeNet.DataStructs;
using LeetCodeNet.Easy.Trees;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Trees
{
    public sealed class InvertBinaryTree_226_test
    {
        [Theory, ClassData(typeof(InvertBinaryTreeTestData))]
        public void CheckRecursive(TreeNode inputData, TreeNode expected)
        {
            var solver = new InvertBinaryTree_226();
            var result = solver.InvertTreeRecursive(inputData);
            Assert.True(expected.Equals(result));
        }

        [Theory, ClassData(typeof(InvertBinaryTreeTestData))]
        public void CheckIterative(TreeNode inputData, TreeNode expected)
        {
            var solver = new InvertBinaryTree_226();
            var result = solver.InvertTreeIterative(inputData);
            Assert.True(expected.Equals(result));
        }
    }

    public sealed class InvertBinaryTreeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: The LCA of nodes 2 and 8 is 6.

            yield return new object[]
            {
                new TreeNode(4, left: new TreeNode(2, left: new TreeNode(1), right: new TreeNode(3)), right: new TreeNode(7, left: new TreeNode(6), right: new TreeNode(9))),
                new TreeNode(4, left: new TreeNode(7, left: new TreeNode(9), right: new TreeNode(6)), right: new TreeNode(2, left: new TreeNode(3), right: new TreeNode(1)))
            };

            yield return new object[]
            {
                new TreeNode(2, left: new TreeNode(1), right: new TreeNode(3)),
                new TreeNode(2, left: new TreeNode(3), right: new TreeNode(1))
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
