namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-highest-altitude
    /// </summary>
    /// <remarks>
    /// There is a biker going on a road trip. The road trip consists of n + 1 points at different altitudes. The biker starts his trip on point 0 with altitude equal 0.
    /// You are given an integer array gain of length n where gain[i] is the net gain in altitude between points i​​​​​​ and i + 1 for all(0 <= i<n). Return the highest altitude of a point.
    /// </remarks>
    internal sealed class FindtheHighestAltitude_1732
    {
        /// <summary>
        /// ...
        /// </summary>
        /// <param name="gain"> Net gain </param>
        /// <returns> Max altitude at the point </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(1)
        /// </remarks>
        public int LargestAltitude(int[] gain)
        {
            var currentPoint = 0;
            var result = 0;

            for (var index = 0; index < gain.Length; index++)
            {
                var item = gain[index];

                currentPoint += item;

                result = Math.Max(result, currentPoint);
            }

            return result;
        }
    }
}
