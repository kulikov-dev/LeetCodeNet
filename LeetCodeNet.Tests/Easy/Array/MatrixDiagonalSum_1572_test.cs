using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public class MatrixDiagonalSum_1572_test
    {
        [Fact]
        public void Check()
        {
            var solver = new MatrixDiagonalSum_1572();

            //// Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
            /// Notice that element mat[1][1] = 5 is counted only once.
            var input = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
            var result = solver.DiagonalSum(input);
            Assert.Equal(25, result);

            input = new int[][] { new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 } };
            result = solver.DiagonalSum(input);
            Assert.Equal(8, result);
        }

        [Fact]
        public void CheckOptimized()
        {
            var solver = new MatrixDiagonalSum_1572();

            //// Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
            /// Notice that element mat[1][1] = 5 is counted only once.
            var input = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
            var result = solver.DiagonalSumOptimized(input);
            Assert.Equal(25, result);

            input = new int[][] { new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 } };
            result = solver.DiagonalSumOptimized(input);
            Assert.Equal(8, result);
        }
    }
}
