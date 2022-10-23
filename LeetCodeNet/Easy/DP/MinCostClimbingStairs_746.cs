namespace LeetCodeNet.Easy.DP
{
    /// <summary>
    /// https://leetcode.com/problems/min-cost-climbing-stairs/
    /// </summary>
    /// <remarks> 
    /// You are given an integer array cost where cost[i] is the cost of ith step on a staircase. Once you pay the cost, you can either climb one or two steps.
    /// You can either start from the step with index 0, or the step with index 1.
    /// Return the minimum cost to reach the top of the floor.
    /// </remarks>
    public sealed class MinCostClimbingStairs_746
    {
        /// <summary>
        /// Recursive solution
        /// </summary>
        /// <param name="cost"> Array of costs of stairs </param>
        /// <returns> Min cost of climbing </returns>
        /// <remarks>
        /// Time complexity: O(2^n)
        /// Space complexity: O(1)
        /// </remarks>
        public int MinCostClimbingStairsRecursive(int[] cost)
        {
            //// The key idea for most DP solutions is not to rush. First you have to come for solution with recursive approach
            /// It's key for understanding of the problem. And you also can show an interviewer that you can deal with task somehow
            return Math.Min(Recursive(cost, 0), Recursive(cost, 1));
        }

        private int Recursive(int[] cost, int position)
        {
            if (position >= cost.Length)
            {
                return 0;
            }

            var nextStep = Math.Min(Recursive(cost, position + 1), Recursive(cost, position + 2));

            return cost[position] + nextStep;
        }

        /// <summary>
        /// Bottom up solution with tabulation
        /// </summary>
        /// <param name="cost"> Array of costs of stairs </param>
        /// <returns> Min cost of climbing </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public int MinCostClimbingStairsDp1(int[] cost)
        {
            //// Next step is to transform your recursive solution for bottomp-up
            /// I really do like this explanation to solve this kind of tasks: https://leetcode.com/discuss/study-guide/1490172/Dynamic-programming-is-simple 

            var result = new int[cost.Length+2];
            for (var i = cost.Length - 1; i >= 0; i--)
            {
                result[i] = Math.Min(result[i + 1] + cost[i], result[i + 2] + cost[i]);
            }

            return Math.Min(result[0], result[1]);
        }

        /// <summary>
        /// Optimized bottom-up
        /// </summary>
        /// <param name="cost"> Array of costs of stairs </param>
        /// <returns> Min cost of climbing </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public int MinCostClimbingStairsDp2(int[] cost)
        {
            var nextValue = 0;
            var nextNextValue = 0;

            for (var i = cost.Length - 1; i >= 0; i--)
            {
                if (cost[i] + nextValue < cost[i] + nextNextValue)
                {
                    nextNextValue = nextValue;
                    nextValue += cost[i];
                }
                else
                {
                    var temp = nextValue;
                    nextValue = nextNextValue + cost[i];
                    nextNextValue = temp;
                }
            }

            return Math.Min(nextValue, nextNextValue);
        }
    }
}
