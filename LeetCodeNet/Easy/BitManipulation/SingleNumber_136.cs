namespace LeetCodeNet.Easy.BitManipulation
{
    /// <summary>
    /// https://leetcode.com/problems/single-number/
    /// </summary>
    /// <remarks>
    /// Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
    /// You must implement a solution with a linear runtime complexity and use only constant extra space.
    /// </remarks>
    public sealed class SingleNumber_136
    {
        /// <summary>
        /// Bit solution
        /// </summary>
        /// <param name="n"> Array of numbers </param>
        /// <returns> Unique number </returns>
        /// <remarks>
        /// Time complexity: O(1)
        /// Space complexity: O(1)
        /// </remarks>
        public int SingleNumber(int[] nums)
        {
            //// The key idea here is to use XOR. So, the simular numbers will eliminate themselves and we get only unpaired element.
            var result = 0;
            foreach (var num in nums)
            {
                result ^= num;
            }

            return result;
        }
    }
}
