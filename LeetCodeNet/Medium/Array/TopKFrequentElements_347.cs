namespace LeetCodeNet.Medium.Array
{
    /// <summary>
    /// https://leetcode.com/problems/top-k-frequent-elements/
    /// </summary>
    /// <remarks> Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order. </remarks>
    internal sealed class TopKFrequentElements_347
    {
        /// <summary>
        /// Well, the fastest solution is to use the language syntax. Here is the best idea to use LINQ with group by
        /// It solved the problem however the interviewer may check you knowledge of structures, but not the knowledge of the language
        /// This leads us to the second solution
        /// </summary>
        /// <param name="nums"> Input array </param>
        /// <param name="k"> Max K elements </param>
        /// <returns> Frequent elements </returns>
        public int[] TopKFrequentLinq(int[] nums, int k)
        {
            var result = nums.GroupBy(x => x).OrderByDescending(x => x.Count());

            return result.Take(k).Select(x => x.Key).ToArray();
        }

        /// <summary>
        /// The most common algorithm to find "most frequent elements" is the bucket sorting.
        /// Step 1. Iterate through the input array and create dictionary: Key - element, Value - frequent of the element
        /// Step 2. Create the 'bucket'. The array where on the specific index (frequent) we put the list with all elements with this frequent
        /// Step 3. Iterate through the bucket and collect the result.
        /// </summary>
        /// <param name="nums"> Input array </param>
        /// <param name="k"> Max K elements </param>
        /// <returns> Frequent elements </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public int[] TopKFrequentSort(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (!dict.ContainsKey(num))
                {
                    dict.Add(num, 0);
                }

                dict[num]++;
            }

            var bucket = new List<int>[nums.Length + 1];

            foreach (var item in dict)
            {
                if (bucket[item.Value] == null)
                {
                    bucket[item.Value] = new List<int>();
                }

                bucket[item.Value].Add(item.Key);
            }

            var result = new int[k];
            var currentPos = 0;

            for (var i = bucket.Length - 1; i >= 0; i--)
            {
                var list = bucket[i];

                if (list != null)
                {
                    foreach (var item in list)
                    {
                        result[currentPos] = item;

                        ++currentPos;
                        if (currentPos == k)
                        {
                            return result;
                        }
                    }
                }
            }

            return result;
        }
    }
}
