namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/move-zeroes/
    /// </summary>
    /// <remarks> Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements. </remarks>
    public class MoveZeroes_283
    {
        /// <summary>
        /// The idea is to use two-pointers approach. One pointer to current element in array and the second one - to the last left non-zero element
        /// </summary>
        /// <param name="nums"> Array </param>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1), as the task is to replact it in-place
        /// </remarks>
        public void MoveZeroes(int[] nums)
        {
            var leftElementPosition = 0; // Second pointer where we'll put next non-zero element
            for (var i = 0; i < nums.Length; ++i)
            {
                if (nums[i] != 0)
                {
                    var temp = nums[i];
                    nums[i] = 0;
                    nums[leftElementPosition] = temp;
                    ++leftElementPosition;
                }
            }
        }

        /// <summary>
        /// As the next step, according to task we can try to minimize the total number of operations done
        /// Pay attention, that we only imporve the previous solution. So, the main idea is to solve it somehow and only after that try to improve.
        /// </summary>
        /// <param name="nums"> Array </param>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1), as the task is to replact it in-place
        /// </remarks>
        public void MoveZeroesOptimization(int[] nums)
        {
            var leftElementPosition = 0;
            for (var i = 0; i < nums.Length; ++i)
            {
                if (nums[i] != 0)
                {
                    nums[leftElementPosition] = nums[i];
                    ++leftElementPosition;
                }
            }

            //// We don't care about all elements after left pointer, so we can put zero here.
            /// It's not a critical improvements, more saving on breadcrumbs but can show your good level to interviewers
            for (var i = leftElementPosition; i < nums.Length; ++i)
            {
                nums[i] = 0;
            }
        }
    }
}