namespace LeetCodeNet.Medium.Array
{
    /// <summary>
    /// https://leetcode.com/problems/peak-index-in-a-mountain-array
    /// </summary>
    /// <remarks>
    /// An array arr a mountain if the following properties hold:
    /// arr.length >= 3
    /// There exists some i with 0 < i<arr.length - 1 such that:
    /// arr[0] < arr[1] < ... < arr[i - 1] < arr[i]
    /// arr[i]> arr[i + 1] > ... > arr[arr.length - 1]
    /// Given a mountain array arr, return the index i such that arr[0] < arr[1] < ... < arr[i - 1] < arr[i] > arr[i + 1] > ... > arr[arr.length - 1].
    /// You must solve it in O(log(arr.length)) time complexity.
    /// </remarks>
    internal sealed class PeakIndexinaMountainArray_852
    {
        /// <summary>
        /// It's kind of binary-search task. We just change the condition from equal to previous < current, next < current.
        /// </summary>
        /// <param name="arr"> Array </param>
        /// <returns> Index of the peak </returns>
        /// <remarks>
        /// Time complexity: O(log n)
        /// Space complexity: O(1)
        /// </remarks>
        public int PeakIndexInMountainArray(int[] arr)
        {
            var leftIndex = 0;
            var rightIndex = arr.Length - 1;

            while (leftIndex < rightIndex)
            {
                var middleIndex = leftIndex + (rightIndex - leftIndex) / 2;

                if (arr[middleIndex] > arr[middleIndex - 1] && arr[middleIndex] > arr[middleIndex + 1])
                {
                    return middleIndex;
                }

                if (arr[middleIndex] > arr[middleIndex + 1])
                {
                    rightIndex = middleIndex;
                }
                else
                {
                    leftIndex = middleIndex + 1;
                }
            }

            return leftIndex;
        }
    }
}
