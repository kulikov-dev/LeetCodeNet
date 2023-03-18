namespace LeetCodeNet.Easy.LeetMath
{
    /// <summary>
    /// https://leetcode.com/problems/count-odd-numbers-in-an-interval-range/
    /// </summary>
    /// <remarks>
    /// Given two non-negative integers low and high. Return the count of odd numbers between low and high (inclusive).
    /// </remarks>
    internal sealed class CountOddNumbersinanIntervalRange_1523
    {
        /// <summary>
        /// In the array half of the values will always be odd values.
        /// The only exception when both limits are even.
        /// </summary>
        /// <param name="low"> Low limit </param>
        /// <param name="high"> High limit </param>
        /// <returns> Odd amount </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public int CountOdds(int low, int high)
        {
            var isEvenLow = low % 2 == 0;
            var isEvenHigh = high % 2 == 0;

            var halfValue = (high - low) / 2;

            return halfValue + (isEvenLow && isEvenHigh ? 0 : 1);
        }
    }
}
