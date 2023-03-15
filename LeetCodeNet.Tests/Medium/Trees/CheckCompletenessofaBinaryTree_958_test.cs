using System.Collections;
using LeetCodeNet.DataStructs;
using LeetCodeNet.Medium.Trees;

namespace LeetCodeNet.Tests.Medium.Trees
{
    public sealed class CheckCompletenessofaBinaryTree_958_test
    {
        [Theory, ClassData(typeof(CheckCompletenessofaBinaryTreeTestData))]
        public void CheckSimple(TreeNode input, bool expected)
        {
            var solver = new CheckCompletenessofaBinaryTree_958();

            Assert.Equal(expected, solver.IsCompleteTreeFirstAttempt(input));
        }

        [Theory, ClassData(typeof(CheckCompletenessofaBinaryTreeTestData))]
        public void CheckOptimized(TreeNode input, bool expected)
        {
            var solver = new CheckCompletenessofaBinaryTree_958();

            Assert.Equal(expected, solver.IsCompleteTreeOptimized(input));
        }
    }

    public sealed class CheckCompletenessofaBinaryTreeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3, new TreeNode(6))),
                true
            };

            yield return new object[]
            {
                new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3, null, new TreeNode(6))),
                false
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
