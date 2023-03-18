namespace LeetCodeNet.Easy.DP
{
    /// <summary>
    /// https://leetcode.com/problems/climbing-stairs/
    /// </summary>
    /// <remarks>
    /// You are climbing a staircase. It takes n steps to reach the top.
    /// Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top?
    /// </remarks>
    internal sealed class ClimbingStairs_70
    {
        /// <summary>
        /// Recursive solution
        /// </summary>
        /// <param name="n"> N stairs </param>
        /// <returns> Distinct ways to climb </returns>
        /// <remarks>
        /// Time complexity: O(2^n)
        /// Space complexity: O(1)
        /// </remarks>
        public int ClimbStairsRecursive(int n)
        {
            //// The key idea for most DP solutions is not to rush. First you have to come for solution with recursive approach
            /// It's key for understanding of the problem. And you also can show an interviewer that you can deal with task somehow
            if (n == 0)
            {
                return 1;
            }

            if (n < 0)
            {
                return 0;
            }

            return ClimbStairsRecursive(n - 1) + ClimbStairsRecursive(n - 2);
        }

        /// <summary>
        /// Bottom up solution with tabulation
        /// </summary>
        /// <param name="n"> N stairs </param>
        /// <returns> Distinct ways to climb </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public int ClimbStairsDP1(int n)
        {
            //// Please check approach explonation here: MinCostClimbingStairs_746.cs
            var result = new int[n + 2];
            result[n] = 1;

            for (var i = n - 1; i >= 0; --i)
            {
                result[i] = result[i + 1] + result[i + 2];
            }

            return result[0];
        }

        /// <summary>
        /// Optimized bottom-up
        /// </summary>
        /// <param name="n"> N stairs </param>
        /// <returns> Distinct ways to climb </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public int ClimbStairsDP2(int n)
        {
            var nextNextValue = 0;
            var nextValue = 1;
            
            for (var i = n - 1; i >= 0; --i)
            {
                var value = nextNextValue + nextValue;
                nextNextValue = nextValue;
                nextValue = value;
            }

            return nextValue;
        }
    }
}
