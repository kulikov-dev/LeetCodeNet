namespace LeetCodeNet.Medium.Array
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
    /// </summary>
    /// <remarks>
    /// Given a 1-indexed array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number.
    /// Let these two numbers be numbers[index1] and numbers[index2] where 1 <= index1 < index2 <= numbers.length.
    /// Return the indices of the two numbers, index1 and index2, added by one as an integer array[index1, index2] of length 2.
    /// </remarks>
    public sealed class TwoSumII_167
    {
        /// <summary>
        /// The key to this issue is that we have already sorted array. So we can use two-pointers approach to 
        /// </summary>
        /// <param name="numbers"> Sorted array </param>
        /// <param name="target"> Target </param>
        /// <returns> Indexes of sum elements</returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(1)
        /// </remarks>
        public int[] TwoSum(int[] numbers, int target)
        {
            var leftIndex = 0;
            var rightIndex = numbers.Length - 1;

            //// We have only ONE solution, so we don't need to care about left/right indexes intersection
            while (numbers[leftIndex] + numbers[rightIndex] != target)
            {
                var sum = numbers[leftIndex] + numbers[rightIndex];

                if (sum > target)
                {
                    --rightIndex;
                }
                else
                {
                    ++leftIndex;
                }

                //// In case, if we have a variant with no solutions 
                /*  if (leftIndex == rightIndex)
                  {
                      return new int[] { };
                  }*/
            }

            return new[] { leftIndex + 1, rightIndex + 1 };
        }
    }
}
