using System.Collections;
using LeetCodeNet.DataStructs;
using LeetCodeNet.Medium.Trees;

namespace LeetCodeNet.Tests.Medium.Trees
{
    public sealed class ValidateBinarySearchTree_98_test
    {
        [Theory, ClassData(typeof(ValidateBinarySearchTreeTestData))]
        public void CheckRecursive(TreeNode inputData, bool expected)
        {
            var solver = new ValidateBinarySearchTree_98();
            Assert.Equal(expected, solver.IsValidBST(inputData));
        }
    }

    public sealed class ValidateBinarySearchTreeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new TreeNode(2, new TreeNode(1), new TreeNode(3)),
                true
            };

            yield return new object[]
            {
               new TreeNode(5, new TreeNode(1), new TreeNode(4, new TreeNode(3), new TreeNode(6))),
               false
            };

            yield return new object[]
            {
                new TreeNode(5, new TreeNode(4), new TreeNode(6, new TreeNode(3), new TreeNode(7))),
                false
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
