namespace LeetCodeNet.Medium.Array
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-value-of-the-partition/
    /// </summary>
    /// <remarks>
    /// You are given a positive integer array nums.
    /// Partition nums into two arrays, nums1 and nums2, such that:
    /// Each element of the array nums belongs to either the array nums1 or the array nums2.
    /// Both arrays are non-empty.
    /// The value of the partition is minimized.
    /// The value of the partition is |max(nums1) - min(nums2)|.
    /// Here, max(nums1) denotes the maximum element of the array nums1, and min(nums2) denotes the minimum element of the array nums2.
    /// Return the integer denoting the value of such partition.
    /// </remarks>
    internal sealed class FindtheValueofthePartition_2740
    {
        /// <summary>
        /// The partition will be minimized when the two consecutive elements in the source array have the minimum difference.
        /// This division will result in the first sub-array having the maximum value, and the following element will be the minimum of the next sub-array.
        /// To apply this approach, we need to sort the source array first and then successively check two elements to find the minimum difference.
        /// </summary>
        /// <param name="nums"> Input data </param>
        /// <returns> Min. number partition </returns>
        /// <remarks>
        /// Time complexity: O(n * log(n))
        /// Space complexity: O(1)
        /// </remarks>
        public int MinPartitionValue(int[] nums)
        {
            System.Array.Sort(nums);

            var minValue = int.MaxValue;

            for (var i = 1; i < nums.Length; i++)
            {
                minValue = Math.Min(Math.Abs(nums[i] - nums[i - 1]), minValue);
            }

            return minValue;
        }
    }
}
