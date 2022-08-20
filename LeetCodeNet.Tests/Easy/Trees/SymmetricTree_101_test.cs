using System.Collections;
using LeetCodeNet.DataStructs;
using LeetCodeNet.Easy.Trees;

namespace LeetCodeNet.Tests.Easy.Trees
{
    public sealed class SymmetricTree_101_test
    {
        [Theory, ClassData(typeof(SymmetricTreeTestData))]
        public void CheckRecursive(TreeNode inputData, bool expected)
        {
            var solver = new SymmetricTree_101();
            var result = solver.IsSymmetricRecursive(inputData);
            Assert.Equal(expected, result);
        }

        [Theory, ClassData(typeof(SymmetricTreeTestData))]
        public void CheckIterative(TreeNode inputData, bool expected)
        {
            var solver = new SymmetricTree_101();
            var result = solver.IsSymmetricIterative(inputData);
            Assert.Equal(expected, result);
        }
    }

    public sealed class SymmetricTreeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new TreeNode(1, left: new TreeNode(2, left: new TreeNode(3), right: new TreeNode(4)), right: new TreeNode(2, left: new TreeNode(4), right: new TreeNode(3))),
                true
            };

            yield return new object[]
            {
                new TreeNode(1, left: new TreeNode(2, left: new TreeNode(3), right: new TreeNode(4)), right: new TreeNode(2, left: new TreeNode(3), right: new TreeNode(5))),
                false
            };

            yield return new object[]
            {
                new TreeNode(1, left: new TreeNode(2, left: new TreeNode(3), right: new TreeNode(4)), right: new TreeNode(2, left: new TreeNode(3))),
                false
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
