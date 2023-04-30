using LeetCodeNet.Medium.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Medium.Array
{
    public sealed class FirstCompletelyPaintedRoworColumn_2661_test
    {
        [Theory, ClassData(typeof(FirstCompletelyPaintedRoworColumnTestData))]
        public void Check(int[] inputData1, int[][] inputData2, int expected)
        {
            var solver = new FirstCompletelyPaintedRoworColumn_2661();

            Assert.Equal(expected, solver.FirstCompleteIndex(inputData1, inputData2));
        }
    }

    public sealed class FirstCompletelyPaintedRoworColumnTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: The moves are shown in order, and both the first row and second column of the matrix become fully painted at arr[2].
            yield return new object[]
            {
                new int[] { 1,3,4,2},
                new int[][] { new[] {1, 4 }, new[]{ 2,3} },
                2
            };

            yield return new object[]
            {
                new int[] { 2,8,7,4,1,3,5,6,9},
                new int[][] { new[] { 3, 2, 5 }, new[]{ 1, 4 ,6 }, new[]{ 8, 7, 9 } },
                3
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
