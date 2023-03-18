using LeetCodeNet.DataStructs;
using LeetCodeNet.Easy.Trees;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Trees
{
    public sealed class MaximumDepthofBinaryTree_104_test
    {
        [Theory, ClassData(typeof(MaximumDepthofBinaryTreeTestData))]
        public void CheckRecursive(TreeNode inputData, int expected)
        {
            var solver = new MaximumDepthofBinaryTree_104();
            var result = solver.MaxDepthRecursive(inputData);

            Assert.True(expected.Equals(result));
        }

        [Theory, ClassData(typeof(MaximumDepthofBinaryTreeTestData))]
        public void CheckIterative(TreeNode inputData, int expected)
        {
            var solver = new MaximumDepthofBinaryTree_104();
            var result = solver.MaxDepthIterative(inputData);

            Assert.True(expected.Equals(result));
        }
    }

    public sealed class MaximumDepthofBinaryTreeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new TreeNode(3, left: new TreeNode(9), right: new TreeNode(20, left: new TreeNode(15), right: new TreeNode(9))),
                3
            };

            yield return new object[]
            {
                new TreeNode(1, right: new TreeNode(3)),
                2
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
