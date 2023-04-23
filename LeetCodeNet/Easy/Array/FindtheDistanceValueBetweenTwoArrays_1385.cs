
namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-distance-value-between-two-arrays
    /// </summary>
    /// <remarks>
    /// Given two integer arrays arr1 and arr2, and the integer d, return the distance value between the two arrays.
    /// The distance value is defined as the number of elements arr1[i] such that there is not any element arr2[j] where |arr1[i]-arr2[j]| <= d.
    /// </remarks>
    internal sealed class FindtheDistanceValueBetweenTwoArrays_1385
    {
        /// <summary>
        /// Simple approach to create straight solution, which will be accepted
        /// Nested loops for checking.
        /// </summary>
        /// <param name="arr1"> Array 1</param>
        /// <param name="arr2"> Array 2</param>
        /// <param name="d"> d </param>
        /// <returns> Distance</returns>
        /// <remarks>
        /// Time complexity: O(N ^ 2)
        /// Space complexity: O(1)
        /// </remarks>
        public int FindTheDistanceValueSimple(int[] arr1, int[] arr2, int d)
        {
            var result = 0;

            for (var i = 0; i < arr1.Length; ++i)
            {
                var isMatch = true;

                for (var j = 0; j < arr2.Length; ++j)
                {
                    if (Math.Abs(arr1[i] - arr2[j]) <= d)
                    {
                        isMatch = false;

                        break;
                    }
                }

                result += isMatch ? 1 : 0;
            }

            return result;
        }

        /// <summary>
        /// |arr1[i] - arr2[j]| = d is equivalent to arr1[i] - d = arr2[j] = arr1[i] + d.
        /// So, for each value val in the array arr1, we must check (through binary search) whether the array arr2 includes any value in the range val - d to val + d. Otherwise, increase the distance.
        /// </summary>
        /// <param name="arr1"> Array 1</param>
        /// <param name="arr2"> Array 2</param>
        /// <param name="d"> d </param>
        /// <returns> Distance </returns>
        /// <remarks>
        /// Time complexity: O(N log N)
        /// Space complexity: O(1)
        /// </remarks>
        public int FindTheDistanceValueSort(int[] arr1, int[] arr2, int d)
        {
            var result = 0;
            
            System.Array.Sort(arr2);

            for (var i = 0; i < arr1.Length; ++i)
            {
                if (!InRange(arr2, arr1[i] - d, arr1[i] + d))
                {
                    ++result;
                }
            }

            return result;
        }

        private bool InRange(int[] arr, int startRange, int endrange)
        {
            var leftIndex = 0;
            var rightIndex = arr.Length - 1;

            while (leftIndex <= rightIndex)
            {
                var middleIndex = leftIndex + (rightIndex - leftIndex) / 2;

                if (arr[middleIndex] >= startRange && arr[middleIndex] <= endrange)
                {
                    return true;
                }

                if (arr[middleIndex] < startRange)
                {
                    leftIndex = middleIndex + 1;
                }
                else
                {
                    rightIndex = middleIndex - 1;
                }
            }

            return false;
        }
    }
}
