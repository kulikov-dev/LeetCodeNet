namespace LeetCodeNet.Tests.Easy.Array
{
    public class TransposeMatrix_867_test
    {
        [Fact]
        public void Check()
        {
            var solver = new TransposeMatrix_867();

            Assert.Equal(new int[][] { new int[] { 1, 4, 7 }, new int[] { 2, 5, 8 }, new int[] { 3, 6, 9 } }, solver.Transpose(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } }));
            Assert.Equal(new int[][] { new int[] { 1, 4 }, new int[] { 2, 5 }, new int[] { 3, 6 } }, solver.Transpose(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 } }));
        }

        [Fact]
        public void CheckInPlace()
        {
            var solver = new TransposeMatrix_867();

            Assert.Equal(new int[][] { new int[] { 1, 4, 7 }, new int[] { 2, 5, 8 }, new int[] { 3, 6, 9 } }, solver.TransposeInPlace(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } }));
        }
    }
}