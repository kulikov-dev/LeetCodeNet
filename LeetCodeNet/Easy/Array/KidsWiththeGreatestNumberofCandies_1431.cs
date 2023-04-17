namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/kids-with-the-greatest-number-of-candies
    /// </summary>
    /// <remarks>
    /// There are n kids with candies. You are given an integer array candies, where each candies[i] represents the number of candies the ith kid has, and an integer extraCandies,
    /// denoting the number of extra candies that you have.
    /// Return a boolean array result of length n, where result[i] is true if, after giving the ith kid all the extraCandies, they will have the greatest number of candies among all the kids, or false otherwise.
    /// Note that multiple kids can have the greatest number of candies.
    /// </remarks>
    internal sealed class KidsWiththeGreatestNumberofCandies_1431
    {
        /// <summary>
        /// Straight solution contains of two steps:
        /// 1. Count the maximum value
        /// 2. Check through all elements if value + extraCandies is >= current maximum value
        /// </summary>
        /// <param name="candies"> Candies array </param>
        /// <param name="extraCandies"> Added candies </param>
        /// <returns> Array of max candies </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(N), to store results
        /// </remarks>
        public IList<bool> KidsWithCandiesCommon(int[] candies, int extraCandies)
        {
            var maxValue = 0;

            for (var i = 0; i < candies.Length; ++i)
            {
                maxValue = Math.Max(maxValue, candies[i]);
            }

            var result = new bool[candies.Length];

            for (var i = 0; i < candies.Length; ++i)
            {
                if (candies[i] + extraCandies >= maxValue)
                {
                    result[i] = true;
                }
            }

            return result;
        }

        /// <summary>
        /// More shorten solution using linq
        /// </summary>
        /// <param name="candies"> Candies array </param>
        /// <param name="extraCandies"> Added candies </param>
        /// <returns> Array of max candies </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(N), to store results
        /// </remarks>
        public IList<bool> KidsWithCandiesLinq(int[] candies, int extraCandies)
        {
            var maxValue = candies.Max(x => x);

            return candies.Select(x => x + extraCandies >= maxValue).ToArray();
        }
    }
}
