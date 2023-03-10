namespace LeetCodeNet.Medium.Array
{
    /// <summary>
    /// https://leetcode.com/problems/permutations/
    /// </summary>
    /// <remarks> Given an array nums of distinct integers, return all the possible permutations. You can return the answer in any order. </remarks>
    public sealed class Permutations_46
    {
        /// <summary>
        /// Use recursive approach. Well explained here: https://www.geeksforgeeks.org/write-a-c-program-to-print-all-permutations-of-a-given-string/
        /// </summary>
        /// <param name="nums"> Input array </param>
        /// <returns> Permutations </returns>
        /// <remarks>
        /// Time complexity: O(N*N!)
        /// Space complexity: O(N!)
        /// </remarks>
        public IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<IList<int>>();

            Recursive(nums, 0, ref result);
            return result;
        }

        /// <summary>
        /// Support recursive function
        /// </summary>
        /// <param name="nums"> Input array </param>
        /// <param name="index"> Current index </param>
        /// <param name="result"> Permutations </param>
        private void Recursive(int[] nums, int index, ref List<IList<int>> result)
        {
            if (index >= nums.Length)
            {
                result.Add(nums.ToList());
            }

            for (var i = index; i < nums.Length; ++i)
            {
                (nums[index], nums[i]) = (nums[i], nums[index]);    // Syntax sugar to swap values

                Recursive(nums, index + 1, ref result);

                (nums[index], nums[i]) = (nums[i], nums[index]);    // Syntax sugar to swap values
            }
        }
    }
}
