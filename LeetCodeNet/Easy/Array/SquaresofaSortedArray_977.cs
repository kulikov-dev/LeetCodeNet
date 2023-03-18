namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/squares-of-a-sorted-array/
    /// </summary>
    /// <remarks>
    /// Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.
    /// </remarks>
    internal sealed class SquaresofaSortedArray_977
    {
        /// <summary>
        /// Square each element and then sort the new array. Obvious solution
        /// </summary>
        /// <param name="nums"> Array </param>
        /// <returns> Squared sorted array </returns>
        /// <remarks>
        /// Time complexity: O(n log(n))
        /// Space complexity: O(n)
        /// </remarks>
        public int[] SortedSquaresBruteForce(int[] nums)
        {
            var result = nums.Select(x => (int)Math.Pow(x, 2));

            return result.OrderBy(x => x).ToArray();
        }

        /// <summary>
        /// The key is that the array is already sorted (!).  So, we need to use two pointers approach to compare first/last elements,
        /// because after square they both have possibility to be the highest element. -4, 3 -> 16, 9
        /// To apply the idea we will use two-pointers approach to store pointers two first/last elements
        /// </summary>
        /// <param name="nums"> Array </param>
        /// <returns> Squared sorted array </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public int[] SortedSquaresPointers(int[] nums)
        {
            var result = new int[nums.Length];
            var leftPointer = 0;                    // pointers for the left/for the right
            var rightPointer = nums.Length - 1;

            for (var i = nums.Length-1; i >=0; --i)
            {
                var item1 = (int)Math.Pow(nums[leftPointer], 2);
                var item2 = (int)Math.Pow(nums[rightPointer], 2);

                if (item1 < item2)
                {
                    result[i] = item2;

                    --rightPointer;
                }
                else
                {
                    result[i] = item1;

                    ++leftPointer;
                }
            }

            return result;
        }
    }
}
