namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/sort-array-by-parity/
    /// </summary>
    /// <remarks>
    /// Given an integer array nums, move all the even integers at the beginning of the array followed by all the odd integers.
    /// Return any array that satisfies this condition.
    /// </remarks>
    internal sealed class SortArrayByParity_905
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"> Input array </param>
        /// <returns> Ordered array </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public int[] SortArrayByParity(int[] nums)
        {
            var leftIndex = 0;
            var rightIndex = nums.Length - 1;
            var result = new int[nums.Length];
            foreach (var num in nums)
            {
                if (num % 2 == 0)
                {
                    result[leftIndex] = num;
                    ++leftIndex;
                }
                else
                {
                    result[rightIndex] = num;
                    --rightIndex;
                }
            }

            return result;
        }
    }
}
