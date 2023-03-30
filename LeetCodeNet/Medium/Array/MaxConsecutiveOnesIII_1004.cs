namespace LeetCodeNet.Medium.Array
{
    /// <summary>
    /// https://leetcode.com/problems/max-consecutive-ones-iii/
    /// </summary>
    /// <remarks> Given a binary array nums and an integer k, return the maximum number of consecutive 1's in the array if you can flip at most k 0's. </remarks>
    internal sealed class MaxConsecutiveOnesIII_1004
    {
        /// <summary>
        /// Approach here is to use sliding window to detect when we need to use our k-zeroes. When we don't have enough k, we move left pointer to the right for one position.
        /// This is the first attempt I came to. It's kind of obvious, but this will be enough to solve the task.
        /// Step 1. 1,1,1,0,0,0,1,1,1,1,0
        ///         ^
        /// Step 2. 1,1,1,0,0,0,1,1,1,1,0
        ///         x ^
        /// Step 3. 1,1,1,0,0,0,1,1,1,1,0
        ///         x   ^
        /// Step 4. 1,1,1,V,0,0,1,1,1,1,0
        ///         x     ^
        /// Step 5. 1,1,1,V,V,0,1,1,1,1,0
        ///         x       ^
        /// Step 6. 1,1,1,0,V,V,1,1,1,1,0
        ///                 x ^
        /// etc
        /// </summary>
        /// <param name="nums"> Input arrays </param>
        /// <param name="k"> Zeroes to transform amount </param>
        /// <returns> Longest ones </returns>
        /// <remarks>
        /// Time complexity: O(n^2)
        /// Space complexity: O(1)
        /// </remarks>
        public int LongestOnesSimple(int[] nums, int k)
        {
            var leftPointer = 0;
            var availableFlips = k;
            var currentConsecutive = 0;
            var maxConsecutive = 0;

            for (var rightPointer = 0; rightPointer < nums.Length; rightPointer++)
            {
                if (nums[rightPointer] == 1)
                {
                    ++currentConsecutive;
                }
                else if (availableFlips > 0)
                {
                    ++currentConsecutive;
                    --availableFlips;
                }
                else
                {
                    maxConsecutive = Math.Max(maxConsecutive, currentConsecutive);

                    while (nums[leftPointer] == 1 && leftPointer <= rightPointer)
                    {
                        ++leftPointer;
                        --currentConsecutive;
                    }

                    ++leftPointer;
                }
            }

            return Math.Max(maxConsecutive, currentConsecutive);
        }

        /// <summary>
        /// Optimized approach of the sliding window
        /// Step 1. 1,1,1,0,0,0,1,1,1,1,0
        ///         ^
        /// Step 2. 1,1,1,0,0,0,1,1,1,1,0
        ///         x ^
        /// Step 3. 1,1,1,0,0,0,1,1,1,1,0
        ///         x   ^
        /// Step 4. 1,1,1,V,0,0,1,1,1,1,0
        ///         x     ^
        /// Step 5. 1,1,1,V,V,0,1,1,1,1,0
        ///         x       ^
        /// Step 6. 1,1,1,V,V,0,1,1,1,1,0
        ///           x       ^
        /// Step 7. 1,1,1,V,V,0,1,1,1,1,0
        ///             x       ^
        /// Step 8. 1,1,1,V,V,0,1,1,1,1,0
        ///               x       ^
        /// Step 9. 1,1,1,V,V,0,1,1,1,1,0
        ///                 x       ^
        /// Step 10. 1,1,1,0,V,V,1,1,1,1,0
        ///                    x       ^
        /// etc
        /// </summary>
        /// <param name="nums"> Input arrays </param>
        /// <param name="k"> Zeroes to transform amount </param>
        /// <returns> Longest ones </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public int LongestOnesOptimal(int[] nums, int k)
        {
            var leftPointer = 0;
            var result = 0;
            var zeroCount = 0;

            for (var rightPointer = 0; rightPointer < nums.Length; rightPointer++)
            {
                if (nums[rightPointer] == 0)
                {
                    ++zeroCount;
                }

                if (zeroCount > k)
                {
                    if (nums[leftPointer] == 0)
                    {
                        --zeroCount;
                    }

                    ++leftPointer;
                }
                
                result = Math.Max(result, rightPointer - leftPointer + 1);
            }

            return result;
        }
    }
}
