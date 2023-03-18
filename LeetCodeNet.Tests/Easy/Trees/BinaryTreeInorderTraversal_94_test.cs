using LeetCodeNet.DataStructs;
using LeetCodeNet.Easy.Trees;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Trees
{
    public sealed class BinaryTreeInorderTraversal_94_test
    {
        [Theory, ClassData(typeof(BinaryTreeInorderTraversalTestData))]
        public void CheckRecursive(TreeNode inputData, List<int> expected)
        {
            var solver = new BinaryTreeInorderTraversal_94();

            Assert.True(Enumerable.SequenceEqual(expected, solver.InorderTraversalRecursive(inputData)));
        }

        [Theory, ClassData(typeof(BinaryTreeInorderTraversalTestData))]
        public void CheckIterative(TreeNode inputData, List<int> expected)
        {
            var solver = new BinaryTreeInorderTraversal_94();

            Assert.True(Enumerable.SequenceEqual(expected, solver.InorderTraverslIterative(inputData)));
        }
    }

    public sealed class BinaryTreeInorderTraversalTestData : IEnumerable<object[]>
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
               new List<int>(){1,3,2 }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
