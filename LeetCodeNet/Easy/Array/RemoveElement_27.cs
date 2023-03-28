namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/remove-element/
    /// </summary>
    /// <remarks>
    /// Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.
    /// Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:
    /// Change the array nums such that the first k elements of nums contain the elements which are not equal to val.The remaining elements of nums are not important as well as the size of nums.
    /// Return k.
    /// </remarks>
    internal sealed class RemoveElement_27
    {
        /// <summary>
        /// This is a two-pointers solution. We use 'currentPos' pointer to track the last position with non-equal value.
        /// So we will put all next different values just to the currentPos position
        /// </summary>
        /// <param name="nums"> Input nums </param>
        /// <param name="val"> Val to remove </param>
        /// <returns> Current length of the array without val </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(1)
        /// </remarks>
        public int RemoveElement(int[] nums, int val)
        {
            var currentPos = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[currentPos] = nums[i];

                    ++currentPos;
                }
            }

            return currentPos;
        }
    }
}
