namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/intersection-of-two-arrays-ii/
    /// </summary>
    /// <remarks>
    /// Given two integer arrays nums1 and nums2, return an array of their intersection.
    /// Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.
    /// </remarks>
    internal sealed class IntersectionOfTwoArraysII_350
    {
        /// <summary>
        /// The approach is to use the hash to store values and amounts from the first array. Then, using the hash, restore the result array from the second one.
        /// </summary>
        /// <param name="nums1"> Array 1 </param>
        /// <param name="nums2"> Array 2 </param>
        /// <returns> Intersections array </returns>
        /// <remarks>
        /// Time complexity: O(m + n), as we pass through both arrays
        /// Space complexity: O(m + n), to store result list and hash
        /// </remarks>
        public int[] IntersectHash(int[] nums1, int[] nums2)
        {
            //// We don't know the size of an array, so it's better to use List (as it provides a dynamic array).
            /// But we can put capacity, as our result can't be more than the maximum length of both arrays.
            var result = new List<int>(Math.Max(nums1.Length, nums2.Length));
            //// Let's use hash to store numbers as Key and their amounts as Value from the first array
            var dict = new Dictionary<int, int>();

            foreach (var number in nums1)
            {
                if (!dict.ContainsKey(number))
                {
                    dict.Add(number, 0);
                }

                dict[number]++;
            }

            //// Then we just go through second array and fill the result if we have enough amounts for this number
            foreach (var number in nums2)
            {
                if (dict.ContainsKey(number) && dict[number] > 0)
                {
                    result.Add(number);
                    dict[number]--;
                }
            }

            return result.ToArray();
        }

        /// <summary>
        /// Another way is to check intersections between sorted arrays. Now we can use a two pointers approach and do it in one pass.
        /// </summary>
        /// <param name="nums1"> Array 1 </param>
        /// <param name="nums2"> Array 2 </param>
        /// <returns> Intersections array </returns>
        /// <remarks>
        /// Time complexity: O(max(m, n)), now we only need to iterate once using both arrays. It's faster. P.S. Assume that arrays are already sorted.
        /// Space complexity: O(m, n)
        /// </remarks>
        public int[] IntersectSorted(int[] nums1, int[] nums2)
        {
            var nums1Sorted = nums1.OrderBy(x => x).ToArray();
            var nums2Sorted = nums2.OrderBy(x => x).ToArray();
            var result = new List<int>(Math.Max(nums1.Length, nums2.Length));

            var pointer1 = 0;
            var pointer2 = 0;

            while (pointer1 < nums1Sorted.Length && pointer2 < nums2Sorted.Length)
            {
                if (nums1Sorted[pointer1] < nums2Sorted[pointer2])
                {
                    pointer1++;
                }
                else if (nums1Sorted[pointer1] > nums2Sorted[pointer2])
                {
                    pointer2++;
                }
                else
                {
                    result.Add(nums1Sorted[pointer1]);
                    ++pointer1;
                    ++pointer2;
                }
            }

            return result.ToArray();
        }
    }
}