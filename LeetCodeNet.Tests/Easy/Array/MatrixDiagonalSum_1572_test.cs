using LeetCodeNet.Easy.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class MatrixDiagonalSum_1572_test
    {
        [Theory, ClassData(typeof(MatrixDiagonalSumTestData))]
        public void Check(int[][] inputData, int expected)
        {
            var solver = new MatrixDiagonalSum_1572();

            Assert.Equal(expected, solver.DiagonalSum(inputData));
        }

        [Theory, ClassData(typeof(MatrixDiagonalSumTestData))]
        public void CheckOptimized(int[][] inputData, int expected)
        {
            var solver = new MatrixDiagonalSum_1572();

            Assert.Equal(expected, solver.DiagonalSumOptimized(inputData));
        }
    }

    public sealed class MatrixDiagonalSumTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
            /// Notice that element mat[1][1] = 5 is counted only once.
            yield return new object[]
            {
                new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } },
                25
            };

            yield return new object[]
            {
                new int[][] { new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 } },
                8
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
