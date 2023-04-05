namespace LeetCodeNet.Medium.Array
{
    /// <summary>
    /// https://leetcode.com/problems/minimize-maximum-of-array/
    /// </summary>
    /// <remarks>
    /// You are given a 0-indexed array nums comprising of n non-negative integers.
    /// In one operation, you must:
    /// Choose an integer i such that 1 <= i<n and nums[i]> 0.
    /// Decrease nums[i] by 1.
    /// Increase nums[i - 1] by 1.
    /// Return the minimum possible value of the maximum integer of nums after performing any number of operations.
    /// </remarks>
    internal sealed class MinimizeMaximumofArray_2439
    {
        /// <summary>
        /// We calculate the prefix sum arrray and their average. The average is the lower bound of the result,
        /// and it's reachable lower bound by the process in intuition, so this average is the result : (sum + i) / (i + 1)
        /// </summary>
        /// <param name="nums"> Input array </param>
        /// <returns> Minimum possible value </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(1)
        /// </remarks>
        public int MinimizeArrayValue(int[] nums)
        {
            var sum = 0m;
            var result = 0m;

            for (int i = 0; i < nums.Length; ++i)
            {
                sum += nums[i];

                result = Math.Max(result, (sum + i) / (i + 1));
            }
            return (int)result;
        }
    }
}
