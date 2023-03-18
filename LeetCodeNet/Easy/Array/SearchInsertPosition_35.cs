namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/search-insert-position/
    /// </summary>
    /// <remarks> Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
    /// You must write an algorithm with O(log n) runtime complexity.
    /// Great explanation is here: https://leetcode.com/problems/search-insert-position/discuss/423166/Binary-Search-101
    /// </remarks>
    internal sealed class SearchInsertPosition_35
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
        public int SearchInsert(int[] nums, int target)
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
            
            //// If didn't find the element, detect it's position in a sorted array
            /// First condition if it's last element in the array
            return nums[rightPosition] < target ? rightPosition + 1 : leftPosition;
        }
    }
}