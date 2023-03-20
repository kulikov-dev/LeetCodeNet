using LeetCodeNet.Easy.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class FloodFill_733_test
    {
        [Theory, ClassData(typeof(FloodFillTestData))]
        public void CheckRecursive(int[][] inputMatrix, int sr, int sc, int color, int[][] expected)
        {
            var solver = new FloodFill_733();
            var result = solver.FloodFillRecursive(inputMatrix, sr, sc, color);

            Assert.Equal(expected, result);
        }

        [Theory, ClassData(typeof(FloodFillTestData))]
        public void CheckBfs(int[][] inputMatrix, int sr, int sc, int color, int[][] expected)
        {
            var solver = new FloodFill_733();
            var result = solver.FloodFillBfs(inputMatrix, sr, sc, color);

            Assert.Equal(expected, result);
        }
    }

    public sealed class FloodFillTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: From the center of the image with position (sr, sc) = (1, 1) (i.e., the red pixel), 
            ///all pixels connected by a path of the same color as the starting pixel (i.e., the blue pixels) are colored with the new color.
            /// Note the bottom corner is not colored 2, because it is not 4 - directionally connected to the starting pixel.
            yield return new object[]
            {
                new[] { new[] { 1, 1, 1 }, new[] { 1, 1, 0 }, new[] { 1, 0, 1 } },
                1,
                1,
                2,
                new[] { new[] { 2, 2, 2 }, new[] { 2, 2, 0 }, new[] { 2, 0, 1 } }
            };

            yield return new object[]
            {
                new[] { new[] { 0, 0, 0 }, new[] { 0, 0, 0 } },
                0,
                0,
                0,
                new[] { new[] { 0, 0, 0 }, new[] { 0, 0, 0 } }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
