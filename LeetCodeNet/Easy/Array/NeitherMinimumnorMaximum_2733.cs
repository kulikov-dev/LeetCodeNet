namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/neither-minimum-nor-maximum/
    /// </summary>
    /// <remarks>
    /// Given an integer array nums containing distinct positive integers, find and return any number from the array that is neither the minimum nor the maximum value in the array, or -1 if there is no such number.
    /// Return the selected integer.
    /// </remarks>
    internal sealed class NeitherMinimumnorMaximum_2733
    {
        /// <summary>
        /// Straight solution. Find min, max and any number which doesn't equal to min/max.
        /// </summary>
        /// <param name="nums"> Input array </param>
        /// <returns> Nor min/max </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public int FindNonMinOrMax(int[] nums)
        {
            var min = int.MaxValue;
            var max = int.MinValue;

            foreach (var val in nums)
            {
                if (val < min)
                {
                    min = val;
                }

                if (val > max)
                {
                    max = val;
                }
            }

            return nums.FirstOrDefault(x => x != min && x != max, -1);
        }

        /// <summary>
        /// Sort array and take third element.
        /// </summary>
        /// <param name="nums"> Input array </param>
        /// <returns> Nor min/max </returns>
        /// <remarks>
        /// Time complexity: O(log(n))
        /// Space complexity: O(n)
        /// </remarks>
        public int FindNonMinOrMaxSort(int[] nums)
        {
            var sorted = nums.OrderBy(x => x).ToArray();

            return sorted.Length <= 2 ? -1 : sorted[1];
        }
    }
}
