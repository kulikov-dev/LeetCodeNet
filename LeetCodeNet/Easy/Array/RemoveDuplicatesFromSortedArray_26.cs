namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
    /// </summary>
    /// <remarks> 
    /// Given an integer array nums sorted in non-decreasing order,
    /// remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same.
    /// </remarks>
    public class RemoveDuplicatesFromSortedArray_26
    {
        /// <summary>
        /// The idea is to use two-pointers approach. One for the last non-duplicated element and the second one - for iteration through array
        /// </summary>
        /// <param name="nums"> Array </param>
        /// <returns> Elements of non-duplicated </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1), as we change array in-place
        /// </remarks>
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            var leftPointer = 0;
            for (var i = 1; i < nums.Length; ++i)
            {
                if (nums[leftPointer] != nums[i])
                {
                    ++leftPointer;
                    nums[leftPointer] = nums[i];
                }
            }

            //// Just for the test purpose
            for (var i = leftPointer + 1; i < nums.Length; ++i)
            {
                nums[i] = -101;     
            }

            return leftPointer + 1;
        }
    }
}
