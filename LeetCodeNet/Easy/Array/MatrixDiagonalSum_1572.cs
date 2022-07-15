using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/matrix-diagonal-sum/
    /// </summary>
    /// <remarks> Given a square matrix mat, return the sum of the matrix diagonals. </remarks>
    public sealed class MatrixDiagonalSum_1572
    {
        /// <summary>
        /// Take elements from left side and right side in one step. Keep in mind exception for odd length matrix (we don't need to sum a center element twice)
        /// Kind of two pointers approach
        /// </summary>
        /// <param name="mat"> Source matrix </param>
        /// <returns> Sum of diagonals </returns>
        /// <remarks>
        /// Time complexity: O(n), one pass
        /// Space complexity: O(1)
        /// </remarks>
        public int DiagonalSum(int[][] mat)
        {
            var result = 0;
            var j = mat.Length - 1;
            for (var i = 0; i < mat.Length; i++)
            {
                result += mat[i][i];        // Primary diagonals, where row == column
                if (i != j)                 // Prevent adding center element for the odd matrix
                {
                    result += mat[i][j];    // Secondary diagonals, where row + column = n-1
                }

                --j;
            }

            return result;
        }

        /// <summary>
        /// We can optimize the previous solution, by reducing if condition
        /// </summary>
        /// <param name="mat"> Source matrix </param>
        /// <returns> Sum of diagonals </returns>
        /// <remarks>
        /// Time complexity: O(n), one pass
        /// Space complexity: O(1)
        /// </remarks>
        public int DiagonalSumOptimized(int[][] mat)
        {
            var result = 0;
            var j = mat.Length - 1;
            for (var i = 0; i < mat.Length; i++)
            {
                result += mat[i][i];        // Primary diagonals, where row == column
                result += mat[i][j];    // Secondary diagonals, where row + column = n-1
                --j;
            }

            //// So, check matrix for odd length in the end and remove one double added central element
            var centerPos = mat.Length / 2;
            result = mat.Length % 2 == 0 ? result : result - mat[centerPos][centerPos];
            return result;
        }
    }
}
