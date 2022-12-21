namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/majority-element/
    /// </summary>
    /// <remarks>
    /// Given an array nums of size n, return the majority element.
    /// The majority element is the element that appears more than ⌊n / 2⌋ times.You may assume that the majority element always exists in the array.
    /// </remarks>
    public sealed class MajorityElement_169
    {
        /// <summary>
        /// Sort the order and use two pointers to store information about max element
        /// </summary>
        /// <param name="nums"> Array </param>
        /// <returns> Major element </returns>
        /// <remarks>
        /// Time complexity: O(n*log(n))
        /// Space complexity: O(1)
        /// </remarks>
        public int MajorityElement(int[] nums)
        {
            if (nums.Length == 0)
            {
                return -1;
            }

            nums = nums.OrderBy(item => item).ToArray();      // It's not a good idea to change the input value, but we get o(1) space complexity 
            var previousItem = nums[0];
            var currentCounter = 1;
            var maxCounter = 1;
            var maxItem = previousItem;

            for (var i = 1; i < nums.Length; ++i)
            {
                var currentItem = nums[i];

                if (currentItem != previousItem)
                {
                    if (currentCounter > maxCounter)
                    {
                        maxCounter = currentCounter;
                        maxItem = previousItem;
                    }

                    previousItem = currentItem;
                    currentCounter = 0;
                }

                ++currentCounter;
            }

            return currentCounter > maxCounter ? nums[nums.Length - 1] : maxItem;
        }
    }
}
