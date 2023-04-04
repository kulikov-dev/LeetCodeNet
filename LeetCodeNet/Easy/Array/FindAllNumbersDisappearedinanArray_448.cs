namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/
    /// </summary>
    /// <remarks>
    /// Given an array nums of n integers where nums[i] is in the range [1, n], return an array of all the integers in the range [1, n] that do not appear in nums.
    /// </remarks>
    internal sealed class FindAllNumbersDisappearedinanArray_448
    {
        /// <summary>
        /// Solution with additional space to track which number was used
        /// </summary>
        /// <param name="nums"> Array </param>
        /// <returns> List of missing numbers </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public IList<int> FindDisappearedNumbersSimple(int[] nums)
        {
            var result = new List<int>();

            var checker = new bool[nums.Length + 1];

            for (var i = 0; i < nums.Length; ++i)
            {
                if (nums[i] >= checker.Length)
                {
                    continue;
                }

                checker[nums[i]] = true;
            }

            for (var i = 1; i < checker.Length; ++i)
            {
                if (!checker[i])
                {
                    result.Add(i);
                }
            }

            return result;
        }

        /// <summary>
        /// In-place sorting:
        /// Step 1: [4,3,2,7,8,2,3,1]
        /// Step 2: [7,3,2,4,8,2,3,1]
        /// Step 3: [3,3,2,4,8,2,7,1]
        /// Step 4: [2,3,3,4,8,2,7,1]
        /// Step 5: [3,2,3,4,8,2,7,1]
        /// Step 6: [3,2,3,4,1,2,7,8]
        /// Step 7: [1,2,3,4,3,2,7,8]
        /// </summary>
        /// <param name="nums"> Array </param>
        /// <returns> List of missing numbers </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public IList<int> FindDisappearedNumbersSort(int[] nums)
        {
            var result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                while (nums[i] != i + 1 && nums[i] != nums[nums[i] - 1])
                {
                    int tmp = nums[i];
                    nums[i] = nums[tmp - 1];
                    nums[tmp - 1] = tmp;
                }
            }
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1)
                {
                    result.Add(i + 1);
                }
            }
            return result;
        }
    }
}
