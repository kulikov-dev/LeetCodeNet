namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/third-maximum-number/
    /// </summary>
    /// <remarks>
    /// Given an integer array nums, return the third distinct maximum number in this array. If the third maximum does not exist, return the maximum number.
    /// </remarks>
    internal sealed class ThirdMaximumNumber_414
    {
        /// <summary>
        /// Using built-in solution. Linq to distinct the array and order by descending
        /// Keep in mind the situation, when the length < 3.
        /// </summary>
        /// <param name="nums"> Input array </param>
        /// <returns> Third max </returns>
        /// <remarks>
        /// Time complexity: O(n * log(n))
        /// Space complexity: O(n)
        /// </remarks>
        public int ThirdMaxLinq(int[] nums)
        {
            var ordered = nums.Distinct().OrderByDescending(x => x).ToList();

            return ordered.Count < 3 ? ordered[0] : ordered[ordered.Count - 1];
        }

        /// <summary>
        /// Less-readable and straight way solution, but it's gives us much better time/space complexity.
        /// Go through the array and track all three numbers. Keep in mind that we can have int.maxvalue in the array, so use nullable variable.
        /// </summary>
        /// <param name="nums"> Input array </param>
        /// <returns> Third max </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public int ThirdMaxByValue(int[] nums)
        {
            int? firstMax = null;
            int? secondMax = null;
            int? thirdMax = null;

            foreach (var num in nums)
            {
                if (num == firstMax || num == secondMax || num == thirdMax)
                {
                    continue;
                }

                if (firstMax == null || num > firstMax)
                {
                    thirdMax = secondMax;
                    secondMax = firstMax;
                    firstMax = num;
                }
                else if (secondMax == null || num > secondMax)
                {
                    thirdMax = secondMax;
                    secondMax = num;
                }
                else if (thirdMax == null || num >= thirdMax)
                {
                    thirdMax = num;
                }
            }

            return thirdMax ?? firstMax!.Value;
        }
    }
}
