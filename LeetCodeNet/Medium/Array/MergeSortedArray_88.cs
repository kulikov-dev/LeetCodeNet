namespace LeetCodeNet.Medium.Array
{
    /// <summary>
    /// https://leetcode.com/problems/merge-sorted-array/
    /// </summary>
    /// <remarks>
    /// You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
    /// Merge nums1 and nums2 into a single array sorted in non-decreasing order.
    /// The final sorted array should not be returned by the function, but instead be stored inside the array nums1.
    /// To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored.
    /// nums2 has a length of n.
    /// </remarks>
    public sealed class MergeSortedArray_88
    {
        /// <summary>
        /// The idea is to start merging from end (like reverse sorting), where we have empty space for merging. It allows us to avoid extra manipulations 
        /// </summary>
        /// <param name="nums1"> Input array 1 </param>
        /// <param name="m"> Elements count </param>
        /// <param name="nums2"> Input array 2 </param>
        /// <param name="n"> Elements 2 count </param>
        /// <remarks>
        /// Time complexity: O(N + M)
        /// Space complexity: O(1)
        /// </remarks>
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            //// [1 2 3 0 0 0]
            ///  [2 5 6]
            ///  Step 1: LastIndex = 5, nums1Pointer = 2, nums2Pointer = 2
            ///  6 > 3, so [1 2 3 0 0 6].
            ///  Step 2: LastIndex = 4, nums1Pointer = 2, nums2Pointer = 1
            ///  5 > 3, so [1 2 3 0 5 6].
            ///  Step 3: LastIndex = 3, nums1Pointer = 2, nums2Pointer = 0
            ///  2 < 3, so [1 2 3 3 5 6].
            ///  Step 4: LastIndex = 2, nums1Pointer = 1, nums2Pointer = 0
            ///  2 < 2, so [1 2 2 3 5 6]
            ///  Step 5. nums2Pos < 0, so we can stop now.

            var lastIndex = nums1.Length - 1;
            var nums1Pointer = m - 1;
            var nums2Pointer = n - 1;

            while (lastIndex > -1)
            {
                if (nums2Pointer < 0)
                {
                    break;
                }

                if (nums1Pointer >= 0 && nums1[nums1Pointer] > nums2[nums2Pointer])
                {
                    nums1[lastIndex] = nums1[nums1Pointer];

                    --nums1Pointer;
                }
                else
                {
                    nums1[lastIndex] = nums2[nums2Pointer];

                    --nums2Pointer;
                }

                --lastIndex;
            }
        }
    }
}
