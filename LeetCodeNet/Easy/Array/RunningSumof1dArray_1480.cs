namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/running-sum-of-1d-array
    /// </summary>
    /// <remarks>
    /// Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
    /// Return the running sum of nums.
    /// </remarks>
    internal sealed class RunningSumof1dArray_1480
    {
        /// <summary>
        /// Use prefix sum approach to calc sum for previous values
        /// </summary>
        /// <param name="nums"> Input array </param>
        /// <returns> Summed array </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(N)
        /// </remarks>
        public int[] RunningSum(int[] nums)
        {
            var sum = 0;
            var result = new int[nums.Length];

            for (var i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                result[i] = sum;
            }

            return result;
        }
    }
}
