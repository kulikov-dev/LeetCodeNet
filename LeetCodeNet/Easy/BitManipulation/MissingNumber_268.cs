namespace LeetCodeNet.Easy.BitManipulation
{
    /// <summary>
    /// https://leetcode.com/problems/missing-number/submissions/
    /// </summary>
    /// <remarks> Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array. </remarks>
    public sealed class MissingNumber_268
    {
        /// <summary>
        /// The easiest way (but not very effective) is to iterate through each number from 0 to N and check if array contains it
        /// </summary>
        /// <param name="nums"> Array </param>
        /// <returns> Missing number </returns>
        /// <remarks>
        /// Time complexity: O(n log n), N for iterating, log n for Contains
        /// Space complexity: O(1)
        /// </remarks>
        public int MissingNumberSimple(int[] nums)
        {
            for (var i = 0; i <= nums.Length; i++)
            {
                if (!nums.Contains(i))
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// The idea is to sum all values from 0 to N (including) and then remove each value in an array
        /// </summary>
        /// <param name="nums"> Array </param>
        /// <returns> Missing number </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public int MissingNumberMath(int[] nums)
        {
            //// As we have array with N values from 0 to N-1, we initialize variable with a last value = N+1
            var sum = nums.Length;
            for (var i = 0; i < nums.Length; ++i)
            {
                //// First step - to count sum of all values from 0 to N
                sum += i;
                //// Second step is to subtract existing value from array
                sum -= nums[i];
            }

            return sum;
        }

        /// <summary>
        /// The same idea, but instead of sum we can use bit XOR operation
        /// </summary>
        /// <param name="nums"> Array </param>
        /// <returns> Missing number </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public int MissingNumberBit(int[] nums)
        {
            var sum = nums.Length;
            for (var i = 0; i < nums.Length; ++i)
            {
                //// When we XOR number to same number - we get 0. So, 
                /// First step - to add all values to sum
                sum ^= i;

                //// Second step is to do XOR with sum. For example if we put 2 to sum and then do sum ^ 2, the result will 0
                sum ^= nums[i];
            }

            return sum;
        }
    }
}