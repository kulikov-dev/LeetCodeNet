namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/find-pivot-index
    /// </summary>
    /// <remarks>
    /// Given an array of integers nums, calculate the pivot index of this array.
    /// The pivot index is the index where the sum of all the numbers strictly to the left of the index is equal to the sum of all the numbers strictly to the index's right.
    /// If the index is on the left edge of the array, then the left sum is 0 because there are no elements to the left.This also applies to the right edge of the array.
    /// Return the leftmost pivot index.If no such index exists, return -1.
    /// </remarks>
    internal sealed class FindPivotIndex_724
    {
        /// <summary>
        /// First idea is to use prefix sum approach, so we can track sum on each step
        /// Input: [1, 7, 3, 6, 5, 6]
        /// index: 0, num: 1, left: 0, right: 27
        /// index: 1, num: 7, left: 1, right: 20
        /// index: 2, num: 3, left: 8, right: 17
        /// index: 3, num: 6, left: 11, right: 11 <-- Found!
        /// </summary>
        /// <param name="nums"> Input array </param>
        /// <returns> Pivot index </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(N)
        /// </remarks>
        public int PivotIndexSimple(int[] nums)
        {
            var sums = new int[nums.Length];
            sums[0] = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                sums[i] = sums[i - 1] + nums[i];
            }

            for (var i = 0; i < sums.Length; ++i)
            {
                var sum = i == 0 ? 0 : sums[i - 1];

                if (sum == sums[sums.Length - 1] - sums[i])
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Optimized approach is developed from the previous solution, as we can calc sum of all array and track in the same way, but with less space complexity
        /// </summary>
        /// <param name="nums"> Input array </param>
        /// <returns> Pivot index </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(1)
        /// </remarks>
        public int PivotIndexOptimizied(int[] nums)
        {
            var leftSum = 0;
            var rightSum = nums.Sum();

            for (var i = 0; i < nums.Length; i++)
            {
                rightSum -= nums[i];
                if (leftSum == rightSum)
                {
                    return i;
                }

                leftSum += nums[i];
            }

            return -1;
        }
    }
}
