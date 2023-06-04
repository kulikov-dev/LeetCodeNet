namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/semi-ordered-permutation/
    /// </summary>
    /// <remarks>
    /// You are given a 0-indexed permutation of n integers nums.
    /// A permutation is called semi-ordered if the first number equals 1 and the last number equals n.You can perform the below operation as many times as you want until you make nums a semi-ordered permutation:
    /// Pick two adjacent elements in nums, then swap them.
    /// Return the minimum number of operations to make nums a semi-ordered permutation.
    /// A permutation is a sequence of integers from 1 to n of length n containing each number exactly once.
    /// </remarks>
    internal sealed class Semi_OrderedPermutation_2717
    {
        /// <summary>
         /// The idea is to find the positions of the element with a value 1 and the element with a value n.
                /// The first position is the number of iterations needed to move an element from its current position to the zero position.
                /// The nums.length - second position is the number of iterations needed to move an element from its current position to the last position.
                /// The corner case is when the first position is larger than the second one. So, we use one swap to change both elements at once.
        /// </summary>
        /// <param name="nums"> Input nums </param>
        /// <returns> Minimum number of operations </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public int SemiOrderedPermutation(int[] nums)
        {
            var leftIndex = -1;
            var rightIndex = -1;

            // Find positions
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    leftIndex = i;
                }
                else if (nums[i] == nums.Length)
                {
                    rightIndex = i;
                }
                else if (leftIndex != -1 && rightIndex != -1)
                {
                    break;
                }
            }

            // Check if already semi-ordered
            if (leftIndex == 0 && rightIndex == nums.Length - 1)
            {
                return 0;
            }

            // Calc number of iterations
            return leftIndex + (nums.Length - rightIndex - 1) + (leftIndex > rightIndex ? -1 : 0);
        }
    }
}
