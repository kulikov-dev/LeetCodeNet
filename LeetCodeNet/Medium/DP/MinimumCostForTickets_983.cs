using Math = System.Math;

namespace LeetCodeNet.Medium.DP
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-cost-for-tickets/
    /// </summary>
    /// <remarks>
    /// You have planned some train traveling one year in advance. The days of the year in which you will travel are given as an integer array days. Each day is an integer from 1 to 365.
    /// Train tickets are sold in three different ways:
    /// a 1-day pass is sold for costs[0] dollars,
    /// a 7-day pass is sold for costs[1] dollars, and
    /// a 30-day pass is sold for costs[2] dollars.
    /// The passes allow that many days of consecutive travel.
    /// For example, if we get a 7-day pass on day 2, then we can travel for 7 days: 2, 3, 4, 5, 6, 7, and 8.
    /// Return the minimum number of dollars you need to travel every day in the given list of days.
    /// </remarks>
    internal sealed class MinimumCostForTickets_983
    {
        /// <summary>
        /// # a = cost[one day pass] + cost of next day
        /// # b = cost[ week pass ] + cost of next day after week
        /// # c = cost[ month pass ] + cost of next day after month
        /// Recursive solution, which gives us TLE
        /// </summary>
        /// <param name="days"> Days to travel </param>
        /// <param name="costs"> Costs </param>
        /// <returns> Min cost </returns>
        /// <remarks>
        /// Time complexity: O(2^n)
        /// Space complexity: O(1), excluded cost of stack of calls
        /// </remarks>
        public int MincostTicketsRecursive(int[] days, int[] costs)
        {
            return Recursive(days, costs, 1, 0);
        }

        /// <summary>
        /// Recursive helper
        /// </summary>
        /// <param name="days"> Days to travel </param>
        /// <param name="costs"> Costs </param>
        /// <param name="currentDay"> Current day </param>
        /// <param name="currentIndex"> Current index </param>
        /// <returns> Min cost </returns>
        private int Recursive(int[] days, int[] costs, int currentDay, int currentIndex)
        {
            while (currentIndex < days.Length && days[currentIndex] < currentDay)
            {
                ++currentIndex;
            }

            if (currentIndex >= days.Length)
            {
                return 0;
            }

            currentDay = days[currentIndex];
            var result1 = Recursive(days, costs, currentDay + 1, currentIndex) + costs[0];
            var result2 = Recursive(days, costs, currentDay + 7, currentIndex) + costs[1];
            var result3 = Recursive(days, costs, currentDay + 30, currentIndex) + costs[2];

            return Math.Min(result1, Math.Min(result2, result3));
        }

        /// <summary>
        /// Bottom-up optimization
        /// </summary>
        /// <param name="days"> Days to travel </param>
        /// <param name="costs"> Costs </param>
        /// <returns> Min cost </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(N)
        /// </remarks>
        public int MincostTicketsBottomUp(int[] days, int[] costs)
        {
            var dp = new int[days.Length];

            for (var i = dp.Length - 1; i >= 0; --i)
            {
                var pos1 = -1;
                var pos7 = -1;
                var pos30 = -1;

                for (var j = i + 1; j < days.Length; ++j)
                {
                    if (pos1 == -1 && days[i] + 1 <= days[j])
                    {
                        pos1 = j;
                    }

                    if (pos7 == -1 && days[i] + 7 <= days[j])
                    {
                        pos7 = j;
                    }

                    if (pos30 == -1 && days[i] + 30 <= days[j])
                    {
                        pos30 = j;
                    }
                }

                var result = (pos1 == -1 ? 0 : dp[pos1]) + costs[0];
                result = Math.Min(result, (pos7 == -1 ? 0 : dp[pos7]) + costs[1]);
                result = Math.Min(result, (pos30 == -1 ? 0 : dp[pos30]) + costs[2]);
                dp[i] = result;
            }

            return dp[0];
        }
    }
}
