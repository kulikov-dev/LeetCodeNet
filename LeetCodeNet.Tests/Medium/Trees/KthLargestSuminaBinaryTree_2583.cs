using System.Collections;
using LeetCodeNet.DataStructs;
using LeetCodeNet.Medium.Trees;

namespace LeetCodeNet.Tests.Medium.Trees
{
    public sealed class KthLargestSuminaBinaryTree_2583_test
    {
        [Theory, ClassData(typeof(KthLargestSuminaBinaryTreeTestData))]
        public void Check(TreeNode input1, int input2, int expected)
        {
            var solver = new KthLargestSuminaBinaryTree_2583();

            var result = solver.KthLargestLevelSum(input1, input2);

            Assert.Equal(expected, result);
        }
    }

    public sealed class KthLargestSuminaBinaryTreeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: The level sums are the following:
            /// -Level 1: 5.
            /// - Level 2: 8 + 9 = 17.
            /// - Level 3: 2 + 1 + 3 + 7 = 13.
            /// - Level 4: 4 + 6 = 10.
            /// The 2nd largest level sum is 13.
            yield return new object[]
            {
                new TreeNode(5, new TreeNode(8, new TreeNode(2, new TreeNode(4), new TreeNode(6)), new TreeNode(1)), new TreeNode(9, new TreeNode(3), new TreeNode(7))),
                2,
                13
            };

            yield return new object[]
            {
               new TreeNode(1, new TreeNode(2, new TreeNode(3))),
               1,
               3
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
