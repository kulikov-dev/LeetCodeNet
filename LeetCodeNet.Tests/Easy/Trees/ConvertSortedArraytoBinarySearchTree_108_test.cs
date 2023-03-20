using LeetCodeNet.DataStructs;
using LeetCodeNet.Easy.Trees;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Trees
{
    public sealed class ConvertSortedArraytoBinarySearchTree_108_test
    {
        [Theory, ClassData(typeof(ConvertSortedArraytoBinarySearchTreeTestData))]
        public void CheckRecursive(int[] inputData, TreeNode expected)
        {
            var solver = new ConvertSortedArraytoBinarySearchTree_108();
            var result = solver.SortedArrayToBST(inputData);

            Assert.True(expected.Equals(result));
        }
    }

    public sealed class ConvertSortedArraytoBinarySearchTreeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[]{ -10, -3, 0, 5, 9 },
                new TreeNode(0, new TreeNode(-10, right: new TreeNode(-3)), new TreeNode(5, right: new TreeNode(9)))
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
