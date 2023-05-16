namespace LeetCodeNet.Medium.Array
{
    /// <summary>
    /// https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array
    /// </summary>
    /// <remarks>
    /// Given an array of integers nums sorted in non-decreasing order, find the starting and ending position of a given target value.
    /// If target is not found in the array, return [-1, -1].
    /// You must write an algorithm with O(log n) runtime complexity.
    /// </remarks>
    internal sealed class FindFirstandLastPositionofElementinSortedArray_34
    {
        /// <summary>
        /// The array must include two indices. This means that to discover each index of the target element, we may just use binary search twice.
        /// </summary>
        /// <param name="nums"> Input array </param>
        /// <param name="target"> Target </param>
        /// <returns> Left/right indexes </returns>
        /// <remarks>
        /// Time complexity: O(log(n))
        /// Space complexity: O(1)
        /// </remarks>
        public int[] SearchRange(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return new[] { -1, -1 };
            }

            var leftTargetIndex = FindLeftIndex(nums, target);
            var rightTargetIndex = FindRightIndex(nums, target);

            return new[] { leftTargetIndex, rightTargetIndex };
        }

        /// <summary>
        /// Find left index of the target
        /// </summary>
        /// <param name="nums"> Input array </param>
        /// <param name="target"> Target </param>
        /// <returns> Left index of the target </returns>
        private int FindLeftIndex(IReadOnlyList<int> nums, int target)
        {
            var leftIndex = 0;
            var rightIndex = nums.Count - 1;
            var result = -1;

            while (leftIndex <= rightIndex)
            {
                var middleIndex = leftIndex + (rightIndex - leftIndex) / 2;

                if (nums[middleIndex] >= target)
                {
                    rightIndex = middleIndex - 1;
                }
                else
                {
                    leftIndex = middleIndex + 1;
                }

                if (nums[middleIndex] == target)
                {
                    result = middleIndex;
                }
            }

            return result;
        }

        /// <summary>
        /// Find right index of the target
        /// </summary>
        /// <param name="nums"> Input array </param>
        /// <param name="target"> Target </param>
        /// <returns> Right index of the target </returns>
        private int FindRightIndex(IReadOnlyList<int> nums, int target)
        {
            var leftIndex = 0;
            var rightIndex = nums.Count - 1;
            var result = -1;

            while (leftIndex <= rightIndex)
            {
                var middleIndex = leftIndex + (rightIndex - leftIndex) / 2;

                if (nums[middleIndex] > target)
                {
                    rightIndex = middleIndex - 1;
                }
                else
                {
                    leftIndex = middleIndex + 1;
                }

                if (nums[middleIndex] == target)
                {
                    result = middleIndex;
                }
            }

            return result;
        }
    }
}
