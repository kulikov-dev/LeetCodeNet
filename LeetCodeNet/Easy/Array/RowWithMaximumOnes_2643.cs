namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/row-with-maximum-ones/
    /// </summary>
    /// <remarks>
    /// Given a m x n binary matrix mat, find the 0-indexed position of the row that contains the maximum count of ones, and the number of ones in that row.
    /// In case there are multiple rows that have the maximum count of ones, the row with the smallest row number should be selected.
    /// Return an array containing the index of the row, and the number of ones in it.
    /// </remarks>
    internal sealed class RowWithMaximumOnes_2643
    {
        /// <summary>
        /// Loop through each row of the matrix and count the number of ones in that row
        /// </summary>
        /// <param name="mat"> Input matrix </param>
        /// <returns> Index/count of max ones </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(1)
        /// </remarks>
        public int[] RowAndMaximumOnes(int[][] mat)
        {
            var maxOnes = 0;
            var maxOnesIndex = 0;

            for (var i = 0; i < mat.Length; ++i)
            {
                var result = 0;

                for (var j = 0; j < mat[i].Length; ++j)
                {
                    if (mat[i][j] == 1)
                    {
                        ++result;
                    }
                }

                if (result > maxOnes)
                {
                    maxOnes = result;
                    maxOnesIndex = i;
                }
            }

            return new[] { maxOnesIndex, maxOnes };
        }
    }
}
