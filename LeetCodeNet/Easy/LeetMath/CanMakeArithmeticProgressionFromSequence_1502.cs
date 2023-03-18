namespace LeetCodeNet.Easy.LeetMath
{
    /// <summary>
    /// https://leetcode.com/problems/can-make-arithmetic-progression-from-sequence/
    /// </summary>
    /// <remarks> A sequence of numbers is called an arithmetic progression if the difference between any two consecutive elements is the same.
    /// Given an array of numbers arr, return true if the array can be rearranged to form an arithmetic progression.Otherwise, return false.
    /// </remarks>
    internal sealed class CanMakeArithmeticProgressionFromSequence_1502
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
        public bool CanMakeArithmeticProgressionSimple(int[] arr)
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

        /// <summary>
        /// Use some math to detect step from min and max elements of the array.
        /// </summary>
        /// <param name="arr"> Array </param>
        /// <returns> Flag, if an arithmetic progression </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(N)
        /// </remarks>
        public bool CanMakeArithmeticProgressionMath(int[] arr)
        {
            var min = int.MaxValue;
            var max = int.MinValue;

            foreach (var element in arr)
            {
                min = Math.Min(min, element);
                max = Math.Max(max, element);
            }


            if ((max - min) % (arr.Length - 1) != 0)
            {
                return false;
            }

            var step = (max - min) / (arr.Length - 1);

            //// Situation, when all elements are zero
            if (step == 0)
            {
                return true;
            }

            //// Use hashset, so we can check if we have duplicated elements
            var hashSet = new HashSet<int>();

            foreach (var element in arr)
            {
                if ((element - min) % step != 0)
                {
                    return false;
                }

                if (!hashSet.Add(element))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
