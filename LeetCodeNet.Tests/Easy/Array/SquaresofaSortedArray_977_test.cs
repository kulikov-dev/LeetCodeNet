using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public class SquaresofaSortedArray_977_test
    {
        [Fact]
        public void CheckBruteForce()
        {
            var solver = new SquaresofaSortedArray_977();

            //// Explanation: After squaring, the array becomes [16,1,0,9,100]. After sorting, it becomes[0, 1, 9, 16, 100].
            Assert.Equal(new int[] { 0, 1, 9, 16, 100 }, solver.SortedSquaresBruteForce(new int[] { -4, -1, 0, 3, 10 }));

            Assert.Equal(new int[] { 4, 9, 9, 49, 121 }, solver.SortedSquaresBruteForce(new int[] { -7, -3, 2, 3, 11 }));
        }

        [Fact]
        public void CheckPointers()
        {
            var solver = new SquaresofaSortedArray_977();

            Assert.Equal(new int[] { 0, 1, 9, 16, 100 }, solver.SortedSquaresPointers(new int[] { -4, -1, 0, 3, 10 }));
            Assert.Equal(new int[] { 4, 9, 9, 49, 121 }, solver.SortedSquaresPointers(new int[] { -7, -3, 2, 3, 11 }));
        }
    }
}