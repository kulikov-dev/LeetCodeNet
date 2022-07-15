namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/
    /// </summary>
    public class TwoSum_1
    {
        /// <summary>
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        /// </summary>
        /// <param name="nums"> List of nums </param>
        /// <param name="target"> Value we need to find </param>
        /// <returns> Indices of the two numbers </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public int[] TwoSum(int[] nums, int target)
        {
            //// The idea is to use Hash for storing: difference between target number and current number for Key; and index as value
            var result = new Dictionary<int, int>(nums.Length);
            for (var i = 0; i < nums.Length; ++i)
            {
                var diff = target - nums[i];
                if (result.ContainsKey(diff))
                {
                    return new int[2] { result[diff], i };
                }

                result.Add(nums[i], i);
            }

            throw new ArgumentException("Input parameters not valid");
        }
    }
}