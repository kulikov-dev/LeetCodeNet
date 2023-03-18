using System.Collections;
using LeetCodeNet.DataStructs;
using LeetCodeNet.Easy.Trees;

namespace LeetCodeNet.Tests.Easy.Trees
{
    public sealed class SearchinaBinarySearchTree_700_test
    {
        [Theory, ClassData(typeof(SearchinaBinarySearchTreeTestData))]
        public void CheckRecursive(TreeNode inputData1, int inputData2, TreeNode expected)
        {
            var solver = new SearchinaBinarySearchTree_700();
            var result = solver.SearchBSTRecursive(inputData1, inputData2);

            Assert.Equal(expected, result);
        }

        [Theory, ClassData(typeof(SearchinaBinarySearchTreeTestData))]
        public void CheckIterative(TreeNode inputData1, int inputData2, TreeNode expected)
        {
            var solver = new SearchinaBinarySearchTree_700();
            var result = solver.SearchBSTIterative(inputData1, inputData2);

            Assert.Equal(expected, result);
        }
    }

    public sealed class SearchinaBinarySearchTreeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var expected = new TreeNode(2, left: new TreeNode(1), right: new TreeNode(3));

            yield return new object[]
            {
                new TreeNode(4, left: expected, right: new TreeNode(7)),
                2,
                expected
            };

            yield return new object[]
            {
                new TreeNode(4, left: expected, right: new TreeNode(7)),
                5,
                null
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
