namespace LeetCodeNet.Medium.Array
{
    /// <summary>
    /// https://leetcode.com/problems/find-minimum-in-rotated-sorted-array
    /// </summary>
    /// <remarks>
    /// Suppose an array of length n sorted in ascending order is rotated between 1 and n times. For example, the array nums = [0,1,2,4,5,6,7] might become:
    /// [4,5,6,7,0,1,2] if it was rotated 4 times.
    /// [0, 1, 2, 4, 5, 6, 7] if it was rotated 7 times.
    /// Notice that rotating an array[a[0], a[1], a[2], ..., a[n - 1]] 1 time results in the array[a[n - 1], a[0], a[1], a[2], ..., a[n - 2]].
    /// Given the sorted rotated array nums of unique elements, return the minimum element of this array.
    /// You must write an algorithm that runs in O(log n) time.
    /// </remarks>
    internal sealed class FindMinimuminRotatedSortedArray_153
    {
        /// <summary>
        /// We will use binary search to find the index of the element, where the array starts to be rotated
        /// Then check first element and first rotated.
        /// </summary>
        /// <param name="nums"> Input array </param>
        /// <returns> Minimum value </returns>
        /// <remarks>
        /// Time complexity: O(n*log(n))
        /// Space complexity: O(1)
        /// </remarks>
        public int FindMin(int[] nums)
        {
            var leftIndex = 0;
            var rightIndex = nums.Length - 1;

            while (leftIndex < rightIndex)
            {
                var middleIndex = leftIndex + (rightIndex - leftIndex) / 2;

                if (nums[middleIndex] > nums[rightIndex])
                {
                    leftIndex = middleIndex + 1;
                }
                else
                {
                    rightIndex = middleIndex;
                }
            }

            return Math.Min(nums[leftIndex], nums[0]);
        }
    }
}
