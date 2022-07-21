namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/sum-of-all-odd-length-subarrays/
    /// </summary>
    /// <remarks>
    /// Given an array of positive integers arr, return the sum of all possible odd-length subarrays of arr.
    /// </remarks>
    public class SumofAllOddLengthSubarrays_1588
    {
        /// <summary>
        /// Direct solution is to do brute force. Get sum of each subarray and check if subarray is odd.
        /// </summary>
        /// <param name="arr"> Input array </param>
        /// <returns> Sum of odd arrays </returns>
        /// <remarks>
        /// Time complexity: O(n^2)
        /// Space complexity: O(1)
        /// </remarks>
        public int SumOddLengthSubarraysBruteForce(int[] arr)
        {
            var result = 0;
            for (var i = 0; i < arr.Length; ++i)
            {
                var amount = 0;
                var subSum = 0;
                for (var j = i; j < arr.Length; ++j)
                {
                    ++amount;
                    subSum += arr[j];
                    if (amount % 2 > 0)
                    {
                        result += subSum;
                    }

                }
            }

            return result;
        }

        /// <summary>
        /// The approach is that every element will contribute size of array by formula (i+1) * (n-i). For example:
        /// With [1,2,3,4] we have for i = 0: [1][1-2][1-2-3][1-2-3-4]. As we need only odd, we can divide result.
        /// The key for this type of tasks - is to take note and try to reproduce a few steps, it helps you to find out relation
        /// </summary>
        /// <param name="arr"> Input array </param>
        /// <returns> Sum of odd arrays </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public int SumOddLengthSubarraysMath(int[] arr)
        {
            var result = 0;
            for (var i = 0; i < arr.Length; ++i)
            {
                var totalSubArrays = (i + 1) * (arr.Length - i);
                var oddSubArrays = totalSubArrays / 2;
                if (totalSubArrays % 2 == 1)
                {
                    ++oddSubArrays;
                }

                result += arr[i] * oddSubArrays;
            }

            return result;
        }
    }
}