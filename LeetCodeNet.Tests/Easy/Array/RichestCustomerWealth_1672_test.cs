using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public class RichestCustomerWealth_1672_test
    {
        [Fact]
        public void CheckLinq()
        {
            var solver = new RichestCustomerWealth_1672();

            //// Explanation:
            /// 1st customer has wealth = 1 + 2 + 3 = 6
            /// 2nd customer has wealth = 3 + 2 + 1 = 6
            /// Both customers are considered the richest with a wealth of 6 each, so return 6.
            Assert.Equal(6, solver.MaximumWealthLinq(new int[][] { new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 } }));
            Assert.Equal(10, solver.MaximumWealthLinq(new int[][] { new int[] { 1, 5 }, new int[] { 7, 3 }, new int[] { 3, 5 } }));
        }

        [Fact]
        public void CheckPass()
        {
            var solver = new RichestCustomerWealth_1672();
            Assert.Equal(6, solver.MaximumWealthPass(new int[][] { new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 } }));
            Assert.Equal(10, solver.MaximumWealthPass(new int[][] { new int[] { 1, 5 }, new int[] { 7, 3 }, new int[] { 3, 5 } }));
        }
    }
}
