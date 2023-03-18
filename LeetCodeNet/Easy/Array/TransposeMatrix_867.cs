namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/transpose-matrix/
    /// </summary>
    /// <remarks>
    /// Given a 2D integer array matrix, return the transpose of matrix.
    /// The transpose of a matrix is the matrix flipped over its main diagonal, switching the matrix's row and column indices.
    /// </remarks>
    internal sealed class TransposeMatrix_867
    {
        /// <summary>
        /// Nothing special. Rows become columns and vice versa. 
        /// </summary>
        /// <param name="matrix"> Matrix </param>
        /// <returns> Transponed matrix </returns>
        /// <remarks>
        /// Time complexity: O(n * m), as two cycles: n for the row, m for the column
        /// Space complexity: O(n * m)
        /// </remarks>
        public int[][] Transpose(int[][] matrix)
        {
            if (matrix.Length == 0)
            {
                return matrix;
            }

            var result = new int[matrix[0].Length][];

            for (var i = 0; i < matrix.Length; ++i)
            {
                for (var j = 0; j < matrix[i].Length; ++j)
                {
                    if (i == 0)
                    {
                        result[j] = new int[matrix.Length];
                    }

                    result[j][i] = matrix[i][j];
                }
            }

            return result;
        }

        /// <summary>
        /// The following up question is to do it in-place for square matrix
        /// </summary>
        /// <param name="matrix"> Matrix </param>
        /// <returns> Transponed matrix </returns>
        /// <remarks>
        /// Time complexity: O(n * m)
        /// Space complexity: O(1)
        /// </remarks>
        public int[][] TransposeInPlace(int[][] matrix)
        {
            if (matrix.Length == 0)
            {
                return matrix;
            }

            for (var i = 0; i < matrix.Length; ++i)
            {
                //// The trick is to prevent double-transponing, so we use first index in second loop for preventing:
                for (var j = i + 1; j < matrix.Length; ++j)
                {
                    var temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }

            return matrix;
        }

    }
}