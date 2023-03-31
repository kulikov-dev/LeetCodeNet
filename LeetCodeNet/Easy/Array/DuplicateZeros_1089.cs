namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/duplicate-zeros/
    /// </summary>
    /// <remarks>
    /// Given a fixed-length integer array arr, duplicate each occurrence of zero, shifting the remaining elements to the right.
    /// Note that elements beyond the length of the original array are not written.Do the above modifications to the input array in place and do not return anything.
    /// </remarks>
    internal sealed class DuplicateZeros_1089
    {
        /// <summary>
        /// The problem can be solved:
        /// * with a copy (extra space)
        /// * by inserting zeros (extra time)
        /// Here is the second approach. The length of the new array will be sourceArray.Length + countOfZeroes
        /// So, we can apply two pointers approach. First pointer is the position in the original array
        /// Second pointer is the position in the new array.
        /// </summary>
        /// <param name="arr"> Input array </param>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(1)
        /// </remarks>
        public void DuplicateZeros(int[] arr)
        {
            var zeroCounter = 0;

            for (var i = arr.Length - 1; i >= 0; --i)
            {
                if (arr[i] == 0)
                {
                    zeroCounter++;
                }
            }

            if (zeroCounter == 0)
            {
                return;
            }

            var newRightPointer = arr.Length + zeroCounter - 1;

            for (var i = arr.Length - 1; i >= 0; --i)
            {
                if (newRightPointer < arr.Length)
                {
                    arr[newRightPointer] = arr[i];
                }

                if (arr[i] == 0)
                {
                    --newRightPointer;
                    if (newRightPointer < arr.Length)
                    {
                        arr[newRightPointer] = arr[i];
                    }
                }

                --newRightPointer;
            }
        }
    }
}