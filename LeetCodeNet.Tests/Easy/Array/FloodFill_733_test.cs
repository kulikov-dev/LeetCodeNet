using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public class FloodFill_733_test
    {
        [Fact]
        public void CheckRecursive()
        {
            var solver = new FloodFill_733();

            //// Explanation: From the center of the image with position (sr, sc) = (1, 1) (i.e., the red pixel), 
            ///all pixels connected by a path of the same color as the starting pixel (i.e., the blue pixels) are colored with the new color.
            /// Note the bottom corner is not colored 2, because it is not 4 - directionally connected to the starting pixel.
            var input = new int[][] { new int[] { 1, 1, 1 }, new int[] { 1, 1, 0 }, new int[] { 1, 0, 1 } };
            var expectedResult = new int[][] { new int[] { 2, 2, 2 }, new int[] { 2, 2, 0 }, new int[] { 2, 0, 1 } };
            var result = solver.FloodFillRecursive(input, 1, 1, 2);
            Assert.Equal(expectedResult, result);

            input = new int[][] { new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 } };
            expectedResult = new int[][] { new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 } };
            result = solver.FloodFillRecursive(input, 0, 0, 0);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void CheckBfs()
        {
            var solver = new FloodFill_733();

            var input = new int[][] { new int[] { 1, 1, 1 }, new int[] { 1, 1, 0 }, new int[] { 1, 0, 1 } };
            var expectedResult = new int[][] { new int[] { 2, 2, 2 }, new int[] { 2, 2, 0 }, new int[] { 2, 0, 1 } };
            var result = solver.FloodFillBfs(input, 1, 1, 2);
            Assert.Equal(expectedResult, result);

            input = new int[][] { new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 } };
            expectedResult = new int[][] { new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 } };
            result = solver.FloodFillBfs(input, 0, 0, 0);
            Assert.Equal(expectedResult, result);
        }
    }
}
