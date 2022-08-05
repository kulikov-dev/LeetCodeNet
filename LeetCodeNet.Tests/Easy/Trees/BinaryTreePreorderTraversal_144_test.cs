using LeetCodeNet.DataStructs;
using LeetCodeNet.Easy.Trees;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Trees
{
    public class BinaryTreePreorderTraversal_144_test
    {
        [Theory, ClassData(typeof(BinaryTreePreorderTraversalTestData))]
        public void CheckRecursive(TreeNode inputData, List<int> expected)
        {
            var solver = new BinaryTreePreorderTraversal_144();
            Assert.True(Enumerable.SequenceEqual(expected, solver.PreorderTraversalRecurssive(inputData)));
        }

        [Theory, ClassData(typeof(BinaryTreePreorderTraversalTestData))]
        public void CheckIterative(TreeNode inputData, List<int> expected)
        {
            var solver = new BinaryTreePreorderTraversal_144();
            Assert.True(Enumerable.SequenceEqual(expected, solver.PreorderTraversalIterative(inputData)));
        }
    }

    public class BinaryTreePreorderTraversalTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new TreeNode(1),
                new List<int>(){ 1 }
            };

            yield return new object[]
            {
               null,
               new List<int>()
            };

            yield return new object[]
           {
               new TreeNode(1, null, new TreeNode(2, new TreeNode(3))),
               new List<int>(){ 1, 2, 3 }
           };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}