using System.Collections;
using LeetCodeNet.DataStructs;
using LeetCodeNet.Medium.Trees;

namespace LeetCodeNet.Tests.Medium.Trees
{
    public sealed class SumRootToLeafNumbers_129_test
    {
        [Theory, ClassData(typeof(SumRootToLeafNumbersTestData))]
        public void CheckRecursive(TreeNode inputData, int expected)
        {
            var solver = new SumRootToLeafNumbers_129();
            Assert.Equal(expected, solver.SumNumbersRecursive(inputData));
        }

        [Theory, ClassData(typeof(SumRootToLeafNumbersTestData))]
        public void CheckDFS(TreeNode inputData, int expected)
        {
            var solver = new SumRootToLeafNumbers_129();
            Assert.Equal(expected, solver.SumNumberDFS(inputData));
        }
    }

    public sealed class SumRootToLeafNumbersTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new TreeNode(1, new TreeNode(2), new TreeNode(3)),
                25
            };

            yield return new object[]
            {
               new TreeNode(4, new TreeNode(9, new TreeNode(5), new TreeNode(1)), new TreeNode(0)),
               1026
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
