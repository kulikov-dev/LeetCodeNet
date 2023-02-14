namespace LeetCodeNet.Easy.Design
{
    /// <summary>
    /// https://leetcode.com/problems/range-sum-query-immutable/
    /// </summary>
    /// <remarks>
    /// Given an integer array nums, handle multiple queries of the following type:
    /// Calculate the sum of the elements of nums between indices left and right inclusive where left <= right.
    /// </remarks>
    public sealed class NumArray
    {
        private int[] sumNums;

        public NumArray(int[] nums)
        {
            if (nums.Length == 0)
            {
                return;
            }

            sumNums = new int[nums.Length];

            //// The idea is to create the cumulative array to store sum of previous values:
            /// With source array: -2, 0, 3, -5, 2, -1
            /// We will get the helper array like: -2, -2, 1, -4, -2, -3
            var sum = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                sumNums[i] = sum;
            }
        }

        public int SumRange(int left, int right)
        {
            //// The trickiest part is to get the idea how to return the correct value
            if (left == 0)
            {
                //// If the left index is zero - we just need to return value from right index: as it's contains sum of all previous values.
                return sumNums[right];
            }

            //// In other cases we need to keep in mind, that we don't need the sum for values before left index:
            /// So for our helper array: -2, -2, 1, -4, -2, -3, left = 2, right = 5
            /// The result is -3 - (-2) = -1.
            /// The detailed explanation with images you can find here: https://leetcode.com/problems/range-sum-query-immutable/solutions/75194/explanation-with-images/
            return sumNums[right] - sumNums[left - 1];
        }
    }
}
