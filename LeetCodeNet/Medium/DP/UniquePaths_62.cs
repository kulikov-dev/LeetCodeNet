namespace LeetCodeNet.Medium.DP
{
    /// <summary>
    /// https://leetcode.com/problems/unique-paths
    /// </summary>
    /// <remarks>
    /// There is a robot on an m x n grid. The robot is initially located at the top-left corner (i.e., grid[0][0]). The robot tries to move to the bottom-right corner (i.e., grid[m - 1][n - 1]).
    /// The robot can only move either down or right at any point in time.
    /// Given the two integers m and n, return the number of possible unique paths that the robot can take to reach the bottom-right corner.
    /// The test cases are generated so that the answer will be less than or equal to 2 * 109.
    /// </remarks>
    internal sealed class UniquePaths_62
    {
        /// <summary>
        /// Like usual in DP tasks, it's better to solve it in a recursion way. <see cref="MinCostClimbingStairs_746"/>
        /// Unfortunately it gives Time limit exceeded
        /// </summary>
        /// <param name="m"> Length I </param>
        /// <param name="n"> Length J </param>
        /// <returns> Unique paths amount </returns>
        /// <remarks>
        /// Time complexity: O(2^n)
        /// Space complexity: O(1), excluded cost of stack of calls
        /// </remarks>
        public int UniquePathsRecursive(int m, int n)
        {
            return Recursive(m, n, 0, 0);
        }

        /// <summary>
        /// Recursive helper
        /// </summary>
        /// <param name="m"> Length I </param>
        /// <param name="n"> Length J </param>
        /// <param name="currentM"> Current I </param>
        /// <param name="currentN"> Current J </param>
        /// <returns></returns>
        private int Recursive(int m, int n, int currentM, int currentN)
        {
            if (currentM == m - 1 && currentN == n - 1)
            {
                return 1;
            }

            if (currentM >= m || currentN >= n)
            {
                return 0;
            }

            var result = 0;

            result += Recursive(m, n, currentM + 1, currentN);
            result += Recursive(m, n, currentM, currentN + 1);
            return result;
        }

        /// <summary>
        /// Then move to the bottom up solution
        /// </summary>
        /// <param name="m"> Length I </param>
        /// <param name="n"> Length J </param>
        /// <returns> Unique paths amount </returns>
        /// <remarks>
        /// Time complexity: O(2^n)
        /// Space complexity: O(1), excluded cost of stack of calls
        /// </remarks>
        public int UniquePathsBottomUp(int m, int n)
        {
            var dp = new int[m][];

            for (var i = 0; i < dp.Length; ++i)
            {
                dp[i] = new int[n];
            }

            for (var i = 0; i < m; ++i)
            {
                for (var j = 0; j < n; ++j)
                {
                    if (i == 0 || j == 0)
                    {
                        dp[i][j] = 1;
                    }
                    else
                    {
                        dp[i][j] = dp[i - 1][j] + dp[i][j - 1];
                    }
                }
            }

            return dp[m - 1][n - 1];
        }

        /// <summary>
        /// And optimize it.
        /// </summary>
        /// <param name="m"> Length I </param>
        /// <param name="n"> Length J </param>
        /// <returns> Unique paths amount </returns>
        /// <remarks>
        /// Time complexity: O(2^n)
        /// Space complexity: O(1), excluded cost of stack of calls
        /// </remarks>
        public int UniquePathsBottomUpOptimized(int m, int n)
        {
            var dp = new int[n];

            for (var i = 0; i < dp.Length; ++i)
            {
                dp[i] = 1;
            }

            for (var i = 1; i < m; ++i)
            {
                for (var j = 1; j < n; ++j)
                {
                    dp[j] += dp[j - 1];
                }
            }

            return dp[n - 1];
        }
    }
}
