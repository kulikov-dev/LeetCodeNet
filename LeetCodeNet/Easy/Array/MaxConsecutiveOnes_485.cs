namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/max-consecutive-ones/
    /// </summary>
    /// <remarks>
    /// Given a binary array nums, return the maximum number of consecutive 1's in the array.
    /// </remarks>
    internal sealed class MaxConsecutiveOnes_485
    {
        /// <summary>
        /// Use counter to save previous consecutive 1's number and iterate through the nums array.
        /// Reset the current counter if nums[i] != 1
        /// </summary>
        /// <param name="nums"> Input </param>
        /// <returns> Max consecutive ones </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(1)
        /// </remarks>
        public int FindMaxConsecutiveOnesSimple(int[] nums)
        {
            var counter = 0;
            var maxConsecutive = 0;

            for (var i = 0; i < nums.Length; ++i)
            {
                if (nums[i] == 1)
                {
                    ++counter;
                }
                else if (counter > 0)
                {
                    maxConsecutive = Math.Max(maxConsecutive, counter);
                    counter = 0;
                }
            }

            //// Just to check the situation, where the last values are 1's.
            return Math.Max(maxConsecutive, counter);
        }

        /// <summary>
        /// The same approach but with syntax sugar.
        /// </summary>
        /// <param name="nums"> Input </param>
        /// <returns> Max consecutive ones </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(1)
        /// </remarks>
        public int FindMaxConsecutiveOnesShort(int[] nums)
        {
            var counter = 0;
            var maxConsecutive = 0;

            for (var i = 0; i < nums.Length; ++i)
            {
                counter = nums[i] == 0 ? 0 : counter + 1;
                maxConsecutive = Math.Max(maxConsecutive, counter);
            }

            //// Just to check the situation, where the last values are 1's.
            return Math.Max(maxConsecutive, counter);
        }
    }
}
