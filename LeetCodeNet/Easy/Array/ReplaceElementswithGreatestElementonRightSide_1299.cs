namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/replace-elements-with-greatest-element-on-right-side/
    /// </summary>
    /// <remarks>
    /// Given an array arr, replace every element in that array with the greatest element among the elements to its right, and replace the last element with -1.
    /// After doing so, return the array.
    /// </remarks>
    internal sealed class ReplaceElementswithGreatestElementonRightSide_1299
    {
        /// <summary>
        /// Straight forward. We should iterate from back to start. First max element will be initialized as -1, according to the condition.
        /// </summary>
        /// <param name="arr"> Input array </param>
        /// <returns> Converted array </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1), as we change array in-place
        /// </remarks>
        public int[] ReplaceElements(int[] arr)
        {
            var maxElement = -1;

            for (var i = arr.Length - 1; i >= 0; --i)
            {
                var temp = arr[i];
                arr[i] = maxElement;
                maxElement = Math.Max(maxElement, temp);
            }

            return arr;
        }
    }
}
