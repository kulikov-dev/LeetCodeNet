namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/reshape-the-matrix/
    /// </summary>
    /// <remarks>
    /// In MATLAB, there is a handy function called reshape which can reshape an m x n matrix into a new one with a different size r x c keeping its original data.
    /// You are given an m x n matrix mat and two integers r and c representing the number of rows and the number of columns of the wanted reshaped matrix.
    /// The reshaped matrix should be filled with all the elements of the original matrix in the same row-traversing order as they were.
    /// </remarks>
    internal sealed class ReshapeTheMatrix_566
    {
        /// <summary>
        /// Approach is to create pointers for new rows and columns.
        /// </summary>
        /// <param name="mat"> Matrix </param>
        /// <param name="r"> Number of rows </param>
        /// <param name="c"> Number of columns </param>
        /// <returns> Reshaped matrix </returns>
        /// <remarks>
        /// Time complexity: O(n*m)
        /// Space complexity: O(n*m)
        /// </remarks>
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            //// Prevent situation, when new matrix is bigger or smaller than the source
            if (r * c != mat.Length * mat[0].Length)
            {
                return mat;
            }

            var rowPointer = 0;     // Pointer to reshaped matrix row
            var colPointer = 0;     // Pointer to reshaped matrix column
            var result = new int[r][];
            result[0] = new int[c];

            for (var i = 0; i < mat.Length; ++i)
            {
                for (var j = 0; j < mat[i].Length; ++j)
                {
                    // If column pointer is equal to desired size - start a new row
                    if (colPointer == c)
                    {
                        colPointer = 0;

                        ++rowPointer;
                        result[rowPointer] = new int[c];
                    }

                    result[rowPointer][colPointer] = mat[i][j];

                    ++colPointer;           // Increment reshaped column position
                }
            }

            return result;
        }
    }
}