namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/find-lucky-integer-in-an-array
    /// </summary>
    /// <remarks>
    /// Given an array of integers arr, a lucky integer is an integer that has a frequency in the array equal to its value.
    /// Return the largest lucky integer in the array.If there is no lucky integer return -1.
    /// </remarks>
    internal sealed class FindLuckyIntegerinanArray_1394
    {
        /// <summary>
        /// According to our restrictions, we can have only 500 possible numbers. So, we can just create an array with these amount and fill it
        /// </summary>
        /// <param name="arr"> Input array </param>
        /// <returns> Max lucky value </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public int FindLuckyArray(int[] arr)
        {
            var counter = new int[501];

            foreach (var item in arr)
            {
                counter[item]++;
            }

            for (var i = counter.Length - 1; i > 0; --i)
            {
                if (i == counter[i])
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// These variant is more universal, as we can't know input values. So, use dictionary to store numbers instead of the array.
        /// </summary>
        /// <param name="arr"> Input array </param>
        /// <returns> Max lucky value </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public int FindLuckyDict(int[] arr)
        {
            var counter = new Dictionary<int, int>();

            for (var i = 0; i < arr.Length; ++i)
            {
                if (!counter.ContainsKey(arr[i]))
                {
                    counter.Add(arr[i], 0);
                }

                counter[arr[i]]++;
            }

            var maxResult = -1;

            foreach (var item in counter)
            {
                if (item.Key == item.Value)
                {
                    maxResult = Math.Max(maxResult, item.Key);
                }
            }

            return maxResult;
        }
    }
}
