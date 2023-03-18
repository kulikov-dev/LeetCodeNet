namespace LeetCodeNet.Easy.DP
{
    /// <summary>
    /// https://leetcode.com/problems/fibonacci-number/
    /// </summary>
    /// <remarks> 
    /// The Fibonacci numbers, commonly denoted F(n) form a sequence, called the Fibonacci sequence, such that each number is the sum of the two preceding ones, starting from 0 and 1
    /// Given n, calculate F(n).
    /// </remarks>
    internal sealed class FibonacciNumber_509
    {
        /// <summary>
        ///  Recursive solution
        /// </summary>
        /// <param name="n"> Number of Fibonacci </param>
        /// <returns> F(n) </returns>
        /// <remarks>
        /// Time complexity: O(2^n)
        /// Space complexity: O(1)
        /// </remarks>
        public int FibRecursive(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            return FibRecursive(n - 2) + FibRecursive(n - 1);
        }

        /// <summary>
        /// Bottom up solution with tabulation
        /// </summary>
        /// <param name="n"> Number of Fibonacci </param>
        /// <returns> F(n) </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public int FibDp1(int n)
        {
            //// Please check approach explonation here: MinCostClimbingStairs_746.cs
            if (n == 0)
            {
                return 0;
            }

            if ((n == 1) || (n == 2))
            {
                return 1;
            }

            var result = new int[n + 1];
            result[0] = 0;
            result[1] = 1;

            for (var i = 2; i <= n; ++i)
            {
                result[i] = result[i - 1] + result[i - 2];
            }

            return result[n];
        }

        /// <summary>
        /// Optimized bottom-up
        /// </summary>
        /// <param name="n"> Number of Fibonacci </param>
        /// <returns> F(n) </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public int FibDp2(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            var prevPrev = 0;
            var prev = 1;

            for (var i = 2; i <= n; ++i)
            {
                var temp = prev;

                prev += prevPrev;
                prevPrev = temp;
            }

            return prev;
        }
    }
}
