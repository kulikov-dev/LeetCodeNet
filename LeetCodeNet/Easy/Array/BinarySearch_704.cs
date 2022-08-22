namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/binary-search/
    /// </summary>
    /// <remarks> Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums. If target exists, then return its index. Otherwise, return -1.
    /// You must write an algorithm with O(log n) runtime complexity.
    /// Great explanation is here: https://leetcode.com/problems/search-insert-position/discuss/423166/Binary-Search-101
    /// </remarks>
    public sealed class BinarySearch_704
    {
        /// <summary>
        /// If you see 'sorted array' and the task connected with searching - the best approach is to use Binary Search
        /// </summary>
        /// <param name="nums"> Sorted array </param>
        /// <param name="target"> Searchable value </param>
        /// <returns> Index of value </returns>
        /// <remarks>
        /// Time complexity: O(log n)
        /// Space complexity: O(1)
        /// </remarks>
        public int Search(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            var leftPosition = 0;
            var rightPosition = nums.Length - 1;
            while (leftPosition < rightPosition)
            {
                //// Get middle element and check where we have to move - left or right
                var middlePosition = leftPosition + (rightPosition - leftPosition) / 2;
                if (nums[middlePosition] == target)
                {
                    return middlePosition;
                }

                if (nums[middlePosition] < target)
                {
                    leftPosition = middlePosition + 1;
                }
                else
                {
                    rightPosition = middlePosition;
                }
            }

            return -1;
        }
    }
}