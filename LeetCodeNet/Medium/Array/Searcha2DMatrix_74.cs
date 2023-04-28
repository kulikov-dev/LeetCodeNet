namespace LeetCodeNet.Medium.Array
{
    /// <summary>
    /// https://leetcode.com/problems/search-a-2d-matrix/
    /// </summary>
    /// <remarks>
    /// You are given an m x n integer matrix matrix with the following two properties:
    /// Each row is sorted in non-decreasing order.
    /// The first integer of each row is greater than the last integer of the previous row.
    /// Given an integer target, return true if target is in matrix or false otherwise.
    /// You must write a solution in O(log(m* n)) time complexity.
    /// </remarks>
    internal sealed class Searcha2DMatrix_74
    {
        /// <summary>
        /// Treat this m*n array as a single ordered array. So we can apply binary search here.
        /// The trick here is to understand how to transform 1-th array index to 2-th array index.
        /// </summary>
        /// <param name="matrix"> Matrix </param>
        /// <param name="target"> Value to search </param>
        /// <returns> True if matrix contains target </returns>
        /// <remarks>
        /// Time complexity: O(log(m*n))
        /// Space complexity: O(1)
        /// </remarks>
        public bool SearchMatrix(int[][] matrix, int target)
        {
            if (matrix.Length == 0)
            {
                return false;
            }

            var leftIndex = 0;
            var rightIndex = matrix.Length * matrix[0].Length - 1;

            while (leftIndex <= rightIndex)
            {
                var middleIndex = leftIndex + (rightIndex - leftIndex) / 2;
                var row = middleIndex / matrix[0].Length;
                var column = middleIndex % matrix[0].Length;
                var value = matrix[row][column];

                if (value == target)
                {
                    return true;
                }

                if (value > target)
                {
                    rightIndex = middleIndex - 1;
                }
                else
                {
                    leftIndex = middleIndex + 1;
                }
            }

            return false;
        }
    }
}
