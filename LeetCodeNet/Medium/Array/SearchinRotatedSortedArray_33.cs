namespace LeetCodeNet.Medium.Array
{
    /// <summary>
    /// https://leetcode.com/problems/search-in-rotated-sorted-array
    /// </summary>
    /// <remarks>
    /// There is an integer array nums sorted in ascending order (with distinct values).
    /// Prior to being passed to your function, nums is possibly rotated at an unknown pivot index k(1 <= k<nums.length) such that the resulting array is [nums[k], nums[k + 1], ..., nums[n - 1], nums[0], nums[1], ..., nums[k - 1]] (0-indexed). For example, [0, 1, 2, 4, 5, 6, 7] might be rotated at pivot index 3 and become[4, 5, 6, 7, 0, 1, 2].
    /// Given the array nums after the possible rotation and an integer target, return the index of target if it is in nums, or -1 if it is not in nums.
    /// You must write an algorithm with O(log n) runtime complexity.
    /// </remarks>
    internal sealed class SearchinRotatedSortedArray_33
    {
        /// <summary>
        /// Let's divide this problem into two sub-problems:
        /// 1. Find pivot index, where array starts to be rotated
        /// 2. Find if sub-array contains the target
        /// For both sub-problems we can apply binary-search approach.
        /// </summary>
        /// <param name="nums"> Input array </param>
        /// <param name="target"> Target value </param>
        /// <returns> Index of target value </returns>
        /// <remarks>
        /// Time complexity: O(n*log(n))
        /// Space complexity: O(1)
        /// </remarks>
        public int Search(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return -1;
            }

            var pivotIndex = nums.Length == 1 ? -1 : FindPivotIndex(nums);

            if (pivotIndex == 0 || pivotIndex == -1)
            {
                return FindTarget(nums, 0, nums.Length - 1, target);
            }

            var leftIndex = 0;
            var rightIndex = nums.Length - 1;

            if (target >= nums[leftIndex] && target <= nums[pivotIndex - 1])
            {
                rightIndex = pivotIndex;
            }
            else
            {
                leftIndex = pivotIndex;
            }

            return FindTarget(nums, leftIndex, rightIndex, target);
        }

        /// <summary>
        /// Function to find the pivot index
        /// </summary>
        /// <param name="nums"> Input array </param>
        /// <returns> Pivot index </returns>
        private int FindPivotIndex(int[] nums)
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

            return leftIndex;
        }

        /// <summary>
        /// Function to check if sub-array contains a target
        /// </summary>
        /// <param name="nums"> Input array </param>
        /// <param name="leftIndex"> Left index of the sub-array </param>
        /// <param name="rightIndex"> Right index of the sub-array </param>
        /// <param name="target"> Target value </param>
        /// <returns> Index of the target value/ -1 if missing </returns>
        private int FindTarget(int[] nums, int leftIndex, int rightIndex, int target)
        {
            while (leftIndex <= rightIndex)
            {
                var middleIndex = leftIndex + (rightIndex - leftIndex) / 2;

                if (nums[middleIndex] == target)
                {
                    return middleIndex;
                }

                if (nums[middleIndex] > target)
                {
                    rightIndex = middleIndex - 1;

                }
                else
                {
                    leftIndex = middleIndex + 1;
                }
            }

            return -1;
        }
    }
}
