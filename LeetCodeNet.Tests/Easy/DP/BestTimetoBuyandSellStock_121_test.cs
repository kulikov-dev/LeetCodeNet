using LeetCodeNet.Easy.DP;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.DP
{
    public sealed class BestTimetoBuyandSellStock_121_test
    {
        [Theory, ClassData(typeof(BestTimetoBuyandSellStockTestData))]
        public void Check(int[] inputData, int expected)
        {
            var solver = new BestTimetoBuyandSellStock_121();

            Assert.Equal(expected, solver.MaxProfit(inputData));
        }
    }

    public sealed class BestTimetoBuyandSellStockTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
            /// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
            yield return new object[]
            {
                new int[] { 7, 1, 5, 3, 6, 4 },
                5
            };

            //// Explanation: In this case, no transactions are done and the max profit = 0.
            yield return new object[]
            {
                new int[] {7,6,4,3,1},
                0
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}