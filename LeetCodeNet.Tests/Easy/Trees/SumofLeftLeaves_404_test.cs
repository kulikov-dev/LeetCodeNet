using System.Collections;
using LeetCodeNet.DataStructs;
using LeetCodeNet.Easy.Trees;

namespace LeetCodeNet.Tests.Easy.Trees
{
    public sealed class SumofLeftLeaves_404_test
    {
        [Theory, ClassData(typeof(SumofLeftLeavesTestData))]
        public void CheckRecursive(TreeNode inputData, int expected)
        {
            var solver = new SumofLeftLeaves_404();
            var result = solver.SumOfLeftLeavesRecursive(inputData);
            Assert.Equal(expected, result);
        }

        [Theory, ClassData(typeof(SumofLeftLeavesTestData))]
        public void CheckIterative(TreeNode inputData, int expected)
        {
            var solver = new SumofLeftLeaves_404();
            var result = solver.SumOfLeftLeavesIterative(inputData);
            Assert.Equal(expected, result);
        }
    }

    public sealed class SumofLeftLeavesTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new TreeNode(1),
                0
            };

            //// Explanation: There are two left leaves in the binary tree, with values 9 and 15 respectively.
            yield return new object[]
            {
                new TreeNode(3, left: new TreeNode(9), right: new TreeNode(20, left: new TreeNode(15), right: new TreeNode(7))),
                24
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
