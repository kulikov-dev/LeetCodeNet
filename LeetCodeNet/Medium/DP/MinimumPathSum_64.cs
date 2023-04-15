namespace LeetCodeNet.Medium.DP
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-path-sum
    /// </summary>
    /// <remarks>
    /// Given a m x n grid filled with non-negative numbers, find a path from top left to bottom right, which minimizes the sum of all numbers along its path.
    /// Note: You can only move either down or right at any point in time.
    /// </remarks>
    internal sealed class MinimumPathSum_64
    {
        /// <summary>
        /// The simple recursive solution. Need to check for each step if it is optimal or not.
        /// Unfortunately it gives Time limit exceeded
        /// </summary>
        /// <param name="grid"> Source grid </param>
        /// <returns> Min path </returns>
        /// <remarks>
        /// Time complexity: O(2^n)
        /// Space complexity: O(1), excluded cost of stack of calls
        /// </remarks>
        public int MinPathSumRecursive(int[][] grid)
        {
            return Recursive(grid, 0, 0);
        }

        /// <summary>
        /// Recursive helper
        /// </summary>
        /// <param name="grid"> Source grid </param>
        /// <param name="i"> Pos I </param>
        /// <param name="j"> Pos J </param>
        /// <returns> Min path </returns>
        /// <remarks>
        /// Time complexity: O(n * log(n))
        /// Space complexity: O(n)
        /// </remarks>
        private int Recursive(int[][] grid, int i, int j)
        {
            if (i == grid.Length || j == grid[i].Length)
            {
                return int.MaxValue;
            }

            if (i == grid.Length - 1 && j == grid[i].Length - 1)
            {
                return grid[i][j];
            }

            var result1 = Recursive(grid, i + 1, j);
            var result2 = Recursive(grid, i, j + 1);

            return Math.Min(result1, result2) + grid[i][j];
        }

        /// <summary>
        /// Having recursive solution we can transform it to the Bottom Up 
        /// </summary>
        /// <param name="grid"> Source grid </param>
        /// <returns> Min path </returns>
        /// <remarks>
        /// Time complexity: O(n * log(n))
        /// Space complexity: O(1)
        /// </remarks>
        public int MinPathSumBottomUp(int[][] grid)
        {
            var result = new int[grid.Length + 1][];

            for (var i = 0; i < result.Length; i++)
            {
                result[i] = Enumerable.Repeat(int.MaxValue, grid[0].Length + 1).ToArray();
            }

            for (var i = grid.Length - 1; i >= 0; --i)
            {
                for (var j = grid[i].Length - 1; j >= 0; --j)
                {
                    if (i == grid.Length - 1 && j == grid[i].Length - 1)
                    {
                        result[i][j] = grid[i][j];

                        continue;
                    }

                    var result1 = result[i + 1][j];
                    var result2 = result[i][j + 1];

                    result[i][j] = Math.Min(result1, result2) + grid[i][j];
                }
            }

            return result[0][0];
        }

        /// <summary>
        /// And finally we can move forward to memorized solution
        /// </summary>
        /// <param name="grid"> Source grid </param>
        /// <returns> Min path </returns>
        public int MinPathSumBottomUpOptimized(int[][] grid)
        {
            var result = new int[grid[0].Length];
            result[0] = grid[0][0];

            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[i].Length; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        continue;
                    }

                    var result1 = i == 0 ? int.MaxValue : result[j];
                    var result2 = j == 0 ? int.MaxValue : result[j - 1];
                    result[j] = Math.Min(result1, result2) + grid[i][j];
                }
            }

            return result[grid[0].Length - 1];
        }
    }
}
