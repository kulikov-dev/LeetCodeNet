namespace LeetCodeNet.Easy.DP
{
    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
    /// </summary>
    /// <remarks>
    /// You are given an array prices where prices[i] is the price of a given stock on the ith day.
    /// You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
    /// Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.
    /// </remarks>
    public sealed class BestTimetoBuyandSellStock_121
    {
        /// <summary>
        /// The idea is to  find a contiguous sub-array giving maximum profit. The common algorithm to find maximum sub-array is Kadane
        /// </summary>
        /// <param name="prices"> Set of prices </param>
        /// <returns> Profit </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public int MaxProfit(int[] prices)
        {
            var result = 0;
            var tempSum = 0;
            for (var i = 1; i < prices.Length; ++i)
            {
                var diff = prices[i] - prices[i - 1];
                tempSum += diff;
                if (tempSum < 0)
                {
                    tempSum = 0;
                }
                else
                {
                    result = Math.Max(result, tempSum);
                }
            }

            return result;
        }
    }
}
