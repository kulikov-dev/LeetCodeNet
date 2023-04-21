using LeetCodeNet.Medium.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Medium.Array
{
    public sealed class SpiralMatrix_54_test
    {
        [Theory, ClassData(typeof(SpiralMatrixTestData))]
        public void Check(int[][] inputData, List<int> expected)
        {
            var solver = new SpiralMatrix_54();

            Assert.True(expected.SequenceEqual(solver.SpiralOrder(inputData)));
        }
    }

    public sealed class SpiralMatrixTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] { new [] {1, 2, 3}, new [] {4, 5, 6}, new [] {7, 8 ,9}},
                new List<int>{ 1, 2, 3, 6, 9, 8, 7, 4, 5 }
            };

            yield return new object[]
            {
                new[] { new [] {1, 2, 3, 4}, new [] {5, 6, 7, 8}, new [] {9, 10, 11, 12,}},
                new List<int>{ 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
