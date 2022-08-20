using LeetCodeNet.DataStructs;
using LeetCodeNet.Easy.Trees;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Trees
{
    public sealed class BinaryTreePostorderTraversal_145_test
    {
        [Theory, ClassData(typeof(BinaryTreePostorderTraversalTestData))]
        public void CheckRecursive(TreeNode inputData, List<int> expected)
        {
            var solver = new BinaryTreePostorderTraversal_145();
            Assert.True(Enumerable.SequenceEqual(expected, solver.PostorderTraversalRecurssive(inputData)));
        }

        [Theory, ClassData(typeof(BinaryTreePostorderTraversalTestData))]
        public void CheckIterative(TreeNode inputData, List<int> expected)
        {
            var solver = new BinaryTreePostorderTraversal_145();
            Assert.True(Enumerable.SequenceEqual(expected, solver.PostorderTraversalIterative(inputData)));
        }
    }

    public sealed class BinaryTreePostorderTraversalTestData : IEnumerable<object[]>
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
               new List<int>(){ 3,2,1 }
           };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}