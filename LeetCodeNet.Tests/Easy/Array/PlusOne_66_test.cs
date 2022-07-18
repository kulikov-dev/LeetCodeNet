using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public class PlusOne_66_test
    {
        [Fact]
        public void CheckMethod1()
        {
            var solver = new PlusOne_66();

            //// Explanation: The array represents the integer 123. Incrementing by one gives 123 + 1 = 124.
            /// Thus, the result should be[1, 2, 4].
            Assert.Equal(new int[] { 1, 2, 4 }, solver.PlusOne(new int[] { 1, 2, 3 }));

            Assert.Equal(new int[] { 4, 3, 2, 2 }, solver.PlusOne(new int[] { 4, 3, 2, 1 }));
            Assert.Equal(new int[] { 1, 0 }, solver.PlusOne(new int[] { 9 }));
        }
    }
}
