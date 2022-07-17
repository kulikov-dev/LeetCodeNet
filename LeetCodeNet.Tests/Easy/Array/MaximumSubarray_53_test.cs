using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public class MaximumSubarray_53_test
    {
        [Fact]
        public void CheckBruteForse()
        {
            var solver = new MaximumSubarray_53();

            //// Explanation: [4,-1,2,1] has the largest sum = 6.
            Assert.Equal(6, solver.MaxSubArrayBruteForce(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));

            Assert.Equal(1, solver.MaxSubArrayBruteForce(new int[] { 1 }));
            Assert.Equal(23, solver.MaxSubArrayBruteForce(new int[] { 5, 4, -1, 7, 8 }));
        }

        [Fact]
        public void CheckKadane()
        {
            var solver = new MaximumSubarray_53();

            Assert.Equal(6, solver.MaxSubArrayKadane(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
            Assert.Equal(1, solver.MaxSubArrayKadane(new int[] { 1 }));
            Assert.Equal(23, solver.MaxSubArrayKadane(new int[] { 5, 4, -1, 7, 8 }));
        }
    }
}
