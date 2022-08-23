namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/can-make-arithmetic-progression-from-sequence/
    /// </summary>
    /// <remarks> A sequence of numbers is called an arithmetic progression if the difference between any two consecutive elements is the same.
    /// Given an array of numbers arr, return true if the array can be rearranged to form an arithmetic progression.Otherwise, return false.
    /// </remarks>
    public sealed class CanMakeArithmeticProgressionFromSequence_1502
    {
        /// <summary>
        /// Not very effective, but obvious and easy-readable solution is to sort an array
        /// </summary>
        /// <param name="arr"> Array </param>
        /// <returns> Flag, if progression </returns>
        /// <remarks>
        /// Time complexity: O(n log n), N for iterating, log n for sorting
        /// Space complexity: O(n), to keep sorted array, or O(1) if can change params
        /// </remarks>
        public bool CanMakeArithmeticProgression(int[] arr)
        {
            if (arr.Length <= 2)
            {
                return true;
            }

            var sortedArray = arr.OrderBy(x => x).ToList();
            var step = arr[1] - arr[0];
            for (var i = 2; i < sortedArray.Count; ++i)
            {
                if (sortedArray[i] - sortedArray[i - 1] != step)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
