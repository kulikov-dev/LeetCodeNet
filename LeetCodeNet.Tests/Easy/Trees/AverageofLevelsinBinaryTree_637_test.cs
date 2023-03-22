using System.Collections;
using LeetCodeNet.DataStructs;
using LeetCodeNet.Easy.Trees;

namespace LeetCodeNet.Tests.Easy.Trees
{
    public sealed class AverageofLevelsinBinaryTree_637_test
    {
        [Theory, ClassData(typeof(AverageofLevelsinBinaryTreeTestData))]
        public void Check(TreeNode inputData, List<double> expected)
        {
            var solver = new AverageofLevelsinBinaryTree_637();
            var result = solver.AverageOfLevels(inputData);

            Assert.True(expected.SequenceEqual(result));
        }
    }

    public sealed class AverageofLevelsinBinaryTreeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: The average value of nodes on level 0 is 3, on level 1 is 14.5, and on level 2 is 11.
            /// Hence return [3, 14.5, 11].
            yield return new object[]
            {
                new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7))),
                new List<double>(){3, 14.5, 11}
            };

            yield return new object[]
            {
                new TreeNode(3, new TreeNode(9, new TreeNode(15), new TreeNode(7)), new TreeNode(20)),
                new List<double>() {3, 14.5, 11}
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
