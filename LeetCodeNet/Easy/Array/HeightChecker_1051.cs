using static System.Reflection.Metadata.BlobBuilder;

namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/height-checker/
    /// </summary>
    /// <remarks>
    /// A school is trying to take an annual photo of all the students. The students are asked to stand in a single file line in non-decreasing order by height. Let this ordering be represented by the integer array expected where expected[i] is the expected height of the ith student in line.
    /// You are given an integer array heights representing the current order that the students are standing in. Each heights[i] is the height of the ith student in line(0-indexed).
    /// Return the number of indices where heights[i] != expected[i].
    /// </remarks>
    internal sealed class HeightChecker_1051
    {
        /// <summary>
        /// The most intuitive approach is to sort the array and then compare it to the source array.
        /// It's a good approach, but the interviewer can ask for more optimal solution
        /// </summary>
        /// <param name="heights"> Input heights </param>
        /// <returns> Count people to reorder </returns>
        /// <remarks>
        /// Time complexity: O(n * log(n))
        /// Space complexity: O(n)
        /// </remarks>
        public int HeightCheckerSort(int[] heights)
        {
            var sortedHeights = heights.OrderBy(x => x).ToArray();
            var result = 0;

            for (var i = 0; i < heights.Length; ++i)
            {
                result += heights[i] != sortedHeights[i] ? 1 : 0;
            }

            return result;
        }

        /// <summary>
        /// Since the problem said that heights are between 1 and 100 and since we are dealing about heights, which naturally have a limit,
        /// we can actually perform a bucket sort, which only requires O(100n) = O(n) time.
        /// The answer first counts up the heights and puts them on a map, then compares them in order to the heights in the input array.
        /// </summary>
        /// <param name="heights"> Input heights </param>
        /// <returns> Count people to reorder </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public int HeightCheckerBucket(int[] heights)
        {
            var bucket = new int[101];

            foreach (var height in heights)
            {
                ++bucket[height];
            }

            var bucketPointer = 0;
            var result = 0;

            for (var i = 0; i < heights.Length; ++i)
            {
                while (bucket[bucketPointer] == 0 && bucketPointer < bucket.Length)
                {
                    ++bucketPointer;
                }

                if (bucketPointer != heights[i])
                {
                    ++result;
                }

                --bucket[bucketPointer];
            }

            return result;
        }
    }
}
