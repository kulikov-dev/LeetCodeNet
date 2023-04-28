namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/count-negative-numbers-in-a-sorted-matrix
    /// </summary>
    /// <remarks>
    /// Given a m x n matrix grid which is sorted in non-increasing order both row-wise and column-wise, return the number of negative numbers in grid.
    /// </remarks>
    internal sealed class CountNegativeNumbersinaSortedMatrix_1351
    {
        /// <summary>
        /// Since the array is sorted, counting the remaining values without further traversal is possible as soon as the first negative is encountered.
        /// </summary>
        /// <param name="grid"> Input grid </param>
        /// <returns> Count of negative </returns>
        /// <remarks>
        /// Time complexity: O(n*m)
        /// Space complexity: O(1)
        /// </remarks>
        public int CountNegativesSimple(int[][] grid)
        {
            var rows = grid.Length;
            var cols = grid[0].Length;
            var result = 0;

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    if (grid[i][j] < 0)
                    {
                        result += grid[i].Length - j;
                        break;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// The idea is to use BinarySearch for each row.
        /// </summary>
        /// <param name="grid"> Input grid </param>
        /// <returns> Count of negative </returns>
        /// <remarks>
        /// Time complexity: O(n*log(m))
        /// Space complexity: O(1)
        /// </remarks>
        public int CountNegativesBinarySearch(int[][] grid)
        {
            var result = 0;

            for (var i = 0; i < grid.Length; ++i)
            {
                result += BinarySearchCounter(grid[i]);
            }

            return result;
        }

        /// <summary>
        /// Binary Search counter for negative numbers
        /// </summary>
        /// <param name="row"> Row </param>
        /// <returns> Negative numbers amount </returns>
        private int BinarySearchCounter(int[] row)
        {
            if (row[0] < 0)
            {
                return row.Length;
            }

            if (row[row.Length - 1] >= 0)
            {
                return 0;
            }

            var leftIndex = 0;
            var rightIndex = row.Length - 1;

            while (leftIndex < rightIndex)
            {
                var middleIndex = leftIndex + (rightIndex - leftIndex) / 2;

                if (row[middleIndex] >= 0)
                {
                    leftIndex = middleIndex + 1;
                }
                else
                {
                    rightIndex = middleIndex;
                }
            }

            return row[leftIndex] < 0 ? row.Length - leftIndex : 0;

        }
    }
}
