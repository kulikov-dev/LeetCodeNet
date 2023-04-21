namespace LeetCodeNet.Medium.Array
{
    /// <summary>
    /// https://leetcode.com/problems/spiral-matrix
    /// </summary>
    /// <remarks>
    /// Given an m x n matrix, return all elements of the matrix in spiral order.
    /// </remarks>
    internal sealed class SpiralMatrix_54
    {
        /// <summary>
        /// Traverse through the array step by step:
        /// 1. Left column to right column for topRow
        /// 2. Left row to bottom row for rightColumn
        /// 3. Right column to left column for bottomRow
        /// 4. Bottom row to top row for leftColumn
        /// Each step we change indexes and check if borders are valid
        /// </summary>
        /// <param name="matrix"> Matrix </param>
        /// <returns> Spiral matrix representation </returns>
        /// <remarks>
        /// Time complexity: O(N*M)
        /// Space complexity: O(N*M)
        /// </remarks>
        public IList<int> SpiralOrder(int[][] matrix)
        {
            var result = new List<int>();

            var topRowIndex = 0;
            var bottomRowIndex = matrix.Length - 1;

            var leftColumnIndex = 0;
            var rightColumnIndex = matrix[topRowIndex].Length - 1;

            while (true)
            {
                for (var i = leftColumnIndex; i <= rightColumnIndex; ++i)
                {
                    result.Add(matrix[topRowIndex][i]);
                }

                ++topRowIndex;
                if (topRowIndex > bottomRowIndex || leftColumnIndex > rightColumnIndex)
                {
                    break;
                }

                for (var j = topRowIndex; j <= bottomRowIndex; ++j)
                {
                    result.Add(matrix[j][rightColumnIndex]);
                }

                --rightColumnIndex;
                if (topRowIndex > bottomRowIndex || leftColumnIndex > rightColumnIndex)
                {
                    break;
                }

                for (var k = rightColumnIndex; k >= leftColumnIndex; --k)
                {
                    result.Add(matrix[bottomRowIndex][k]);
                }

                --bottomRowIndex;
                if (topRowIndex > bottomRowIndex || leftColumnIndex > rightColumnIndex)
                {
                    break;
                }

                for (var m = bottomRowIndex; m >= topRowIndex; --m)
                {
                    result.Add(matrix[m][leftColumnIndex]);
                }

                leftColumnIndex++;
                if (topRowIndex > bottomRowIndex || leftColumnIndex > rightColumnIndex)
                {
                    break;
                }
            }
            
            return result;
        }
    }
}
