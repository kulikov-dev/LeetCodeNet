namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-distinct-difference-array
    /// </summary>
    /// <remarks>
    /// You are given a 0-indexed array nums of length n.
    /// The distinct difference array of nums is an array diff of length n such that diff[i] is equal to the number of distinct elements in the suffix nums[i + 1, ..., n - 1] subtracted from the number of distinct elements in the prefix nums[0, ..., i].
    /// Return the distinct difference array of nums.
    /// Note that nums[i, ..., j] denotes the subarray of nums starting at index i and ending at index j inclusive.Particularly, if i > j then nums[i, ..., j] denotes an empty subarray.
    /// </remarks>
    internal class FindtheDistinctDifferenceArray_2670
    {
        /// <summary>
        /// For each element we need to know how many unique values before it (including the element) and how many unique values after it
        /// To track values BEFORE we will use kind of prefix sum approach and have the array to store information about it, so:
        /// Array:  1 3 3 5 6 1;
        /// Prefix: 1 2 2 3 4 4
        /// To track unique values AFTER we have Dictionary<int,int> to store information about <value,frequences>, so
        /// Array: 1 3 3 5 6 1;
        /// Dict: 1-2, 3-2, 5-1, 6-1
        /// So, to track differences we need to get prefix sum from the array and dict.length ( - current value) from the dictionary.
        /// Like:
        ///  Step 1: Prefix[0] = 1
        ///          Dict: 1-1, 3-2, 5-1, 6-1
        ///          Result[0] = 1 - 4 = -3
        ///  Step 2: Prefix[1] = 2
        ///          Dict: 1-1, 3-1, 5-1, 6-1
        ///          Result[1] = 2 - 4 = -2
        ///  Step 3. Prefix[2] = 2
        ///          Dict: 1-1, 5-1, 6-1 (remove '3' here, as it frequency = 0)
        ///          Result[2] = 2 - 3 = -1
        /// etc..
        /// </summary>
        /// <param name="nums"> Input array </param>
        /// <returns> Unique value diffs </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public int[] DistinctDifferenceArray(int[] nums)
        {
            var result = new int[nums.Length];
            var frequencesDict = new Dictionary<int, int>();
            var prefixSum = new int[nums.Length];

            for (var i = 0; i < nums.Length; i++)
            {
                if (!frequencesDict.ContainsKey(nums[i]))
                {
                    frequencesDict.Add(nums[i], 0);
                }

                frequencesDict[nums[i]]++;

                prefixSum[i] = frequencesDict.Count;
            }

            for (var i = 0; i < prefixSum.Length; i++)
            {
                frequencesDict[nums[i]]--;
                if (frequencesDict[nums[i]] == 0)
                {
                    frequencesDict.Remove(nums[i]);
                }

                result[i] = prefixSum[i] - frequencesDict.Count;
            }

            return result;
        }
    }
}
