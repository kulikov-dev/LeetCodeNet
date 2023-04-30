namespace LeetCodeNet.Medium.Array
{
    /// <summary>
    /// https://leetcode.com/problems/first-completely-painted-row-or-column/
    /// </summary>
    /// <remarks>
    /// You are given a 0-indexed integer array arr, and an m x n integer matrix mat. arr and mat both contain all the integers in the range [1, m * n].
    /// Go through each index i in arr starting from index 0 and paint the cell in mat containing the integer arr[i].
    /// Return the smallest index i at which either a row or a column will be completely painted in mat.
    /// </remarks>
    internal sealed class FirstCompletelyPaintedRoworColumn_2661
    {
        /// <summary>
        /// The problem can be divided into two sub-problems:
        /// 1. How to find the value in the matrix in a fast way
        /// 2. How to understand that a row or column is completely painted
        /// So,
        /// 1. To solve the first problem, we will create a dictionary with cell values as a key and row/column indices as a value.
        /// It will cost us some space, but it allows us to get information about the cell for O(1) time.
        /// 2. Create two arrays assigned for each rows/columns indices and increase their values during traversal of the arr array.
        ///
        /// When we fill a row or column, we can return the result.
        /// </summary>
        /// <param name="arr"> Array of painting values </param>
        /// <param name="mat"> Input matrix </param>
        /// <returns> The smallest index of completely painted row/column </returns>
        /// <remarks>
        /// Time complexity: O(m*n)
        /// Space complexity: O(m*n)
        /// </remarks>
        public int FirstCompleteIndex(int[] arr, int[][] mat)
        {
            var dict = new Dictionary<int, Tuple<int, int>>();

            for (var i = 0; i < mat.Length; ++i)
            {
                for (var j = 0; j < mat[i].Length; ++j)
                {
                    dict.Add(mat[i][j], new Tuple<int, int>(i, j));
                }
            }

            if (dict.Count == 0)
            {
                return -1;
            }

            var rows = new int[mat.Length];
            var cols = new int[mat[0].Length];

            for (var i = 0; i < arr.Length; ++i)
            {
                var item = dict[arr[i]];

                rows[item.Item1]++;
                cols[item.Item2]++;
                if (rows[item.Item1] == mat[0].Length || cols[item.Item2] == mat.Length)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
