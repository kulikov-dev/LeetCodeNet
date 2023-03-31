namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/valid-mountain-array
    /// </summary>
    /// <remarks>
    /// Given an array of integers arr, return true if and only if it is a valid mountain array.
    /// </remarks>
    internal sealed class ValidMountainArray_941
    {
        /// <summary>
        /// Great explanation with pictures is here <see cref="https://leetcode.com/problems/valid-mountain-array/solutions/1717377/java-c-python-easy-to-go-through-solution-explanation/"/>
        /// </summary>
        /// <param name="arr"> Input array </param>
        /// <returns> True, if mountain </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(1)
        /// </remarks>
        public bool ValidMountainArray(int[] arr)
        {
            if (arr.Length < 3)
            {
                return false;
            }

            var leftIndex = 0;
            var rightIndex = arr.Length - 1;

            while (leftIndex < arr.Length - 1 && arr[leftIndex] < arr[leftIndex + 1])
            {
                ++leftIndex;
            }

            while (rightIndex > 0 && arr[rightIndex] < arr[rightIndex - 1])
            {
                --rightIndex;
            }

            return leftIndex != 0 && rightIndex != arr.Length - 1 && leftIndex == rightIndex;
        }
    }
}
