namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/kth-missing-positive-number
    /// </summary>
    /// <remarks>
    /// Given an array arr of positive integers sorted in a strictly increasing order, and an integer k.
    /// Return the kth positive integer that is missing from this array.
    /// </remarks>
    internal sealed class KthMissingPositiveNumber_1539
    {
        /// <summary>
        /// Simple and elegant. Keep pointer to the array and calc missing numbers
        /// </summary>
        /// <param name="arr"> Input array </param>
        /// <param name="k"> Kth missing </param>
        /// <returns> Kth missing number </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public int FindKthPositive(int[] arr, int k)
        {
            var missingNumbers = 0;
            var arrIndex = 0;

            for (var i = 1; i <= arr.Length +k + 1; ++i)
            {
                if (arrIndex < arr.Length && arr[arrIndex] == i)
                {
                    ++arrIndex;
                }
                else
                {
                    ++missingNumbers;
                    if (missingNumbers == k)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
    }
}
