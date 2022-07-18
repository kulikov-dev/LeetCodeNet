using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public class ReshapeTheMatrix_566_test
    {
        [Fact]
        public void CheckMethod1()
        {
            var solver = new ReshapeTheMatrix_566();
            var result = solver.MatrixReshape(new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } }, 1, 4);

            Assert.Equal(new int[][] { new int[] { 1, 2, 3, 4 } }, result);
        }
    }
}