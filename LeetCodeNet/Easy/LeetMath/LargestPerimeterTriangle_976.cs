namespace LeetCodeNet.Easy.LeetMath
{
    /// <summary>
    /// https://leetcode.com/problems/largest-perimeter-triangle/description/
    /// </summary>
    /// <remarks>
    /// Given an integer array nums, return the largest perimeter of a triangle with a non-zero area, formed from three of these lengths.
    /// If it is impossible to form any triangle of a non-zero area, return 0.
    /// </remarks>
    public sealed class LargestPerimeterTriangle_976
    {
        /// <summary>
        /// We need to calc the perimeter which is sum of three sides of the triangle. We also need to check, that it's a correct formed triangle (where side1 < side2 + side3).
        /// To detect the maxium perimeter - it's a good idea to sort all sides by descending and then check for triangle exist.
        /// </summary>
        /// <param name="nums"> Possible triangle sides </param>
        /// <returns> Largest perimeter </returns>
        /// <remarks>
        /// Time complexity: O(n+log(n))
        /// Space complexity: O(n)
        /// </remarks>
        public int LargestPerimeter(int[] nums)
        {
            var sortedNums = nums.OrderByDescending(x => x).ToList();
            for (var i = 2; i < sortedNums.Count; ++i)
            {
                if (sortedNums[i - 2] < sortedNums[i - 1] + sortedNums[i])
                {
                    return sortedNums[i] + sortedNums[i - 1] + sortedNums[i - 2];
                }
            }

            return 0;
        }
    }
}
