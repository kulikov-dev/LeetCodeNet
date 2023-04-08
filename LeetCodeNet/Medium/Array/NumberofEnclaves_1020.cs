namespace LeetCodeNet.Medium.Array
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-enclaves/
    /// </summary>
    /// <remarks>
    /// You are given an m x n binary matrix grid, where 0 represents a sea cell and 1 represents a land cell.
    /// A move consists of walking from one land cell to another adjacent(4-directionally) land cell or walking off the boundary of the grid.
    /// Return the number of land cells in grid for which we cannot walk off the boundary of the grid in any number of moves.
    /// </remarks>
    internal sealed class NumberofEnclaves_1020
    {
        /// <summary>
        /// The intuitive approach is to flood-fill the land (change 1 to 2) from the grid's boundary. The remaining land is then counted.
        /// We will use DFS to do flood-filling.
        /// </summary>
        /// <param name="grid"> Input grid </param>
        /// <returns> Unconnected land </returns>
        /// <remarks>
        /// Time complexity: O(m*n)
        /// Space complexity: O(1), as we change the grid in-place. It's not a great approach, but here we can use it to simplify.
        /// </remarks>
        public int NumEnclaves(int[][] grid)
        {
            //// To make it faster will check only boundary cells
            for (var i = 0; i < grid.Length; i++)
            {
                Check(i, 0, grid);
                Check(i, grid[0].Length - 1, grid);
            }

            for (var j = 0; j < grid[0].Length; ++j)
            {
                Check(0, j, grid);
                Check(grid.Length - 1, j, grid);
            }

            var result = 0;

            for (var i = 0; i < grid.Length; ++i)
            {
                for (var j = 0; j < grid[0].Length; ++j)
                {
                    if (grid[i][j] == 1)
                    {
                        ++result;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Helper to check if we can fill the connected land and flood the connected cells
        /// </summary>
        /// <param name="i"> Index 1 </param>
        /// <param name="j"> Index 2 </param>
        /// <param name="grid"> Grid </param>
        private void Check(int i, int j, int[][] grid)
        {
            if (i < 0 || j < 0 || i == grid.Length || j == grid[0].Length)
            {
                return;
            }

            if (grid[i][j] == 0 || grid[i][j] == 2)
            {
                return;
            }

            if (grid[i][j] == 1)
            {
                grid[i][j] = 2;
            }

            Check(i + 1, j, grid);
            Check(i - 1, j, grid);
            Check(i, j + 1, grid);
            Check(i, j - 1, grid);
        }
    }
}
