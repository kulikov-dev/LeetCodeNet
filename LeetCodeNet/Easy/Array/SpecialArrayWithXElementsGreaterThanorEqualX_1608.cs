namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/special-array-with-x-elements-greater-than-or-equal-x/
    /// </summary>
    /// <remarks>
    /// You are given an array nums of non-negative integers. nums is considered special if there exists a number x such that there are exactly x numbers in nums that are greater than or equal to x.
    /// Notice that x does not have to be an element in nums.
    /// Return x if the array is special, otherwise, return -1. It can be proven that if nums is special, the value for x is unique.
    /// </remarks>
    internal sealed class SpecialArrayWithXElementsGreaterThanorEqualX_1608
    {
        /// <summary>
        /// The key here is to use sorting and than apply binary searching
        /// </summary>
        /// <param name="nums"> Input array </param>
        /// <returns> Index </returns>
        /// <remarks>
        /// Time complexity: O(log(n))
        /// Space complexity: O(n)
        /// </remarks>
        public int SpecialArray(int[] nums)
        {
            var sortedNums = nums.OrderByDescending(x => x).ToArray();
            var leftIndex = 0;
            var rightIndex = sortedNums.Length;

            while (leftIndex < rightIndex)
            {
                var middleIndex = leftIndex + (rightIndex - leftIndex) / 2;
                var middle = sortedNums[middleIndex];

                if (middleIndex < middle)
                {
                    leftIndex = middleIndex + 1;
                }
                else
                {
                    rightIndex = middleIndex;
                }
            }

            return leftIndex < sortedNums.Length && sortedNums[leftIndex] == leftIndex ? -1 : leftIndex;
        }
    }
}
