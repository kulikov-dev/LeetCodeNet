namespace LeetCodeNet.Medium.Array
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-islands
    /// </summary>
    /// <remarks>
    /// Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), return the number of islands.
    /// An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically.You may assume all four edges of the grid are all surrounded by water.
    /// </remarks>
    internal sealed class NumberofIslands_200
    {
        /// <summary>
        /// The easiest variant here is to use DFS approach and change the modifier of the island.
        /// Here we will change '1' to '0'. It's a good approach in terms of memory complexity.
        /// However it's not a good practice to change input parameters
        /// If we have follow-up question about it - we can use new array with visited cells.
        /// </summary>
        /// <param name="grid"> Map </param>
        /// <returns> Number of islands </returns>
        /// <remarks>
        /// Time complexity: O(n^2)
        /// Space complexity: O(1)
        /// </remarks>
        public int NumIslands(char[][] grid)
        {
            var result = 0;

            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[i].Length; ++j)
                {
                    if (Recursive(grid, i, j))
                    {
                        ++result;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Recursive function to process DFS for each cell
        /// </summary>
        /// <param name="grid"> Map </param>
        /// <param name="i"> Current i index </param>
        /// <param name="j"> Current j index </param>
        /// <returns> True, if any island is visited </returns>
        private bool Recursive(char[][] grid, int i, int j)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] != '1')
            {
                return false;
            }

            grid[i][j] = '2';

            Recursive(grid, i + 1, j);
            Recursive(grid, i - 1, j);
            Recursive(grid, i, j + 1);
            Recursive(grid, i, j - 1);

            return true;
        }
    }
}
