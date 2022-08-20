namespace LeetCodeNet.Medium.Array
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-subarray/
    /// </summary>
    /// <remarks> Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum. </remarks>
    public sealed class MaximumSubarray_53
    {
        /// <summary>
        /// The obvious solution is to use brute force: to calculate the sum of every possible subarray and the maximum of those would be the solution.
        /// Unfortunately, usually it's not possible due to time limit.
        /// </summary>
        /// <param name="nums"> Numbers </param>
        /// <returns> Max sum of the contiguous subarray </returns>
        /// <remarks>
        /// Time complexity: O(n^3)
        /// Space complexity: O(1)
        /// </remarks>
        public int MaxSubArrayBruteForce(int[] nums)
        {
            var result = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    var tempSum = 0;
                    for (int k = i; k <= j; k++)
                    {
                        //// Here we need to calculate sum of all the elements
                        tempSum += nums[k];
                    }

                    result = Math.Max(result, tempSum);
                }
            }

            return result;
        }

        /// <summary>
        /// Another options it to use Kadane's algorithm. As it's a common problem with different variations, so the good idea is to remember it.
        /// </summary>
        /// <param name="nums"> Numbers </param>
        /// <returns> Max sum of the contiguous subarray </returns>
        /// <remarks> Detailed explanation: https://medium.com/@rsinghal757/kadanes-algorithm-dynamic-programming-how-and-why-does-it-work-3fd8849ed73d </remarks>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public int MaxSubArrayKadane(int[] nums)
        {
            var result = int.MinValue;   // To store total maximum sum as result
            var currentSum = 0;          // To store maximum sum to store local maximum sum
            foreach (var number in nums)
            {
                currentSum += number;
                result = Math.Max(result, currentSum);
                if (currentSum < 0)
                {
                    currentSum = 0;
                }
            }

            return result;
        }
    }
}