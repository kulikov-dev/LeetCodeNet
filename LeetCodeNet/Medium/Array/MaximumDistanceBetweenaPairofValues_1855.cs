namespace LeetCodeNet.Medium.Array
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-distance-between-a-pair-of-values
    /// </summary>
    /// <remarks>
    /// You are given two non-increasing 0-indexed integer arrays nums1​​​​​​ and nums2​​​​​​.
    /// A pair of indices(i, j), where 0 <= i<nums1.length and 0 <= j<nums2.length, is valid if both i <= j and nums1[i] <= nums2[j]. The distance of the pair is j - i​​​​.
    /// Return the maximum distance of any valid pair (i, j). If there are no valid pairs, return 0.
    /// An array arr is non-increasing if arr[i - 1] >= arr[i] for every 1 <= i<arr.length.
    /// </remarks>
    internal sealed class MaximumDistanceBetweenaPairofValues_1855
    {
        /// <summary>
        /// As we have sorted arrays we can process them using two pointers approach.
        /// One for the nums1, one for the nums2 arrays.
        /// </summary>
        /// <param name="nums1"> Array 1 </param>
        /// <param name="nums2"> Array 2</param>
        /// <returns> Max distance </returns>
        /// <remarks>
        /// Time complexity: O(N + M)
        /// Space complexity: O(1)
        /// </remarks>
        public int MaxDistance(int[] nums1, int[] nums2)
        {
            var i = 0;
            var j = 0;
            var result = 0;

            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] > nums2[j])
                {
                    ++i;
                }
                else
                {
                    result = Math.Max(result, j - i);

                    ++j;
                }
            }

            return result;
        }
    }
}
