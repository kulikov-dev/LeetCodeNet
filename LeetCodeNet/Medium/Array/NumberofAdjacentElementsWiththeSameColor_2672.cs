namespace LeetCodeNet.Medium.Array
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-adjacent-elements-with-the-same-color
    /// </summary>
    /// <remarks>
    /// There is a 0-indexed array nums of length n. Initially, all elements are uncolored (has a value of 0).
    /// You are given a 2D integer array queries where queries[i] = [indexi, colori].
    /// For each query, you color the index indexi with the color colori in the array nums.
    /// Return an array answer of the same length as queries where answer[i] is the number of adjacent elements with the same color after the ith query.
    /// More formally, answer[i] is the number of indices j, such that 0 <= j<n - 1 and nums[j] == nums[j + 1] and nums[j] != 0 after the ith query.
    /// </remarks>
    internal sealed class NumberofAdjacentElementsWiththeSameColor_2672
    {
        /// <summary>
        /// It's the task of counting. For each query, we will track if there is a difference between the current and neighboring values.
        /// We need to check two variants: if the neighbor is equal to the new value, and if we break the same color, like:
        /// Input array: 0 0 0 0, counter: 0
        ///     Query 1: 0 1 0 0, counter: 0
        ///     Query 2: 0 1 1 0, counter: 1
        ///     Query 3: 0 1 1 1, counter: 2
        ///     Query 4: 0 1 0 1, counter: 0
        /// We check index and index+1. If the old value equals index+1 value then decrement the counter (query 4);
        /// If the new value equals index+1 value then increment the counter (query 2 and 3).
        /// </summary>
        /// <param name="queries"> Queries </param>
        /// <param name="n"> Colors length </param>
        /// <returns> Neighbors changes </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public int[] ColorAdjacentElements(int[][] queries, int n)
        {
            var result = new int[queries.Length];

            var colors = new int[n];
            var currentNeighbors = 0;

            for (var i = 0; i < queries.Length; i++)
            {
                var index = queries[i][0];
                var color = queries[i][1];

                currentNeighbors += Check(colors, colors[index], color, index - 1);
                currentNeighbors += Check(colors, colors[index], color, index + 1);

                colors[index] = color;
                result[i] = currentNeighbors;
            }

            return result;
        }

        /// <summary>
        /// Check neighbors
        /// </summary>
        /// <param name="colors"> Colors </param>
        /// <param name="oldColor"> Old color </param>
        /// <param name="newColor"> New color </param>
        /// <param name="neighborIndex"> Neighbor index </param>
        /// <returns> Counter </returns>
        private int Check(int[] colors, int oldColor, int newColor, int neighborIndex)
        {
            if (neighborIndex == -1 || neighborIndex == colors.Length)
            {
                return 0;
            }

            if (oldColor == newColor)
            {
                return 0;
            }

            if (colors[neighborIndex] == 0)
            {
                return 0;
            }

            var neighborColor = colors[neighborIndex];

            if (newColor == neighborColor)
            {
                return 1;
            }

            return oldColor == neighborColor ? -1 : 0;
        }
    }
}
