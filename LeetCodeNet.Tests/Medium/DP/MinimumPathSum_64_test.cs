using System.Collections;
using LeetCodeNet.Medium.DP;

namespace LeetCodeNet.Tests.Medium.DP
{
    public sealed class MinimumPathSum_64_test
    {
        [Theory, ClassData(typeof(MinimumPathSumTestData))]
        public void CheckRecursive(int[][] inputData, int expected)
        {
            var solver = new MinimumPathSum_64();

            Assert.Equal(expected, solver.MinPathSumRecursive(inputData));
        }

        [Theory, ClassData(typeof(MinimumPathSumTestData))]
        public void CheckBottomUp(int[][] inputData, int expected)
        {
            var solver = new MinimumPathSum_64();

            Assert.Equal(expected, solver.MinPathSumBottomUp(inputData));
        }

        [Theory, ClassData(typeof(MinimumPathSumTestData))]
        public void CheckBottomUpOptimized(int[][] inputData, int expected)
        {
            var solver = new MinimumPathSum_64();

            Assert.Equal(expected, solver.MinPathSumBottomUpOptimized(inputData));
        }
    }

    public sealed class MinimumPathSumTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: Because the path 1 → 3 → 1 → 1 → 1 minimizes the sum.
            yield return new object[]
            {
                new int[][] { new int[] { 1, 3, 1 }, new int[] { 1, 5, 1 }, new int[] { 4, 2, 1 } },
                7
            };

            yield return new object[]
            {
                new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 } },
                12
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}