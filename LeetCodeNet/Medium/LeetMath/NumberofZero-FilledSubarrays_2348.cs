namespace LeetCodeNet.Medium.LeetMath
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-zero-filled-subarrays/
    /// </summary>
    /// <remarks>
    /// Given an integer array nums, return the number of subarrays filled with 0.
    /// A subarray is a contiguous non-empty sequence of elements within an array.
    /// </remarks>
    internal sealed class NumberofZero_FilledSubarrays_2348
    {
        /// <summary>
        /// Math problem. Let's try to figure out the formula.
        /// Assume, that we have array of [0,0,0,0,0], so:
        /// Index 0: 0 at index 0 (sum = 1)
        /// Index 1: 0 at index 0, 0 at index 1, 00 (sum = 3)
        /// Index 2: 0 at index 0, 0 at index 1, 0 at index 2, 00 at indexes 0-1, 00 at indexes 1-2, 000 (sum = 6)
        /// etc.
        /// We can see the idea: N + (N-1) + (N-2) + ... + 1
        /// So we can use counter to calc total amount of current zero sub array and sum it.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public long ZeroFilledSubarray(int[] nums)
        {
            var sum = 0l;
            var zeroSubarrayCount = 0l;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zeroSubarrayCount++;
                    sum += zeroSubarrayCount;
                }
                else
                {
                    zeroSubarrayCount = 0;
                }
            }

            return sum;
        }
    }
}
