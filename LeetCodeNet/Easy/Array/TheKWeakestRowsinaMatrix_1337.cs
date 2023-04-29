
namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/the-k-weakest-rows-in-a-matrix
    /// </summary>
    /// <remarks>
    /// You are given an m x n binary matrix mat of 1's (representing soldiers) and 0's (representing civilians). The soldiers are positioned in front of the civilians. That is, all the 1's will appear to the left of all the 0's in each row.
    /// A row i is weaker than a row j if one of the following is true:
    /// The number of soldiers in row i is less than the number of soldiers in row j.Both rows have the same number of soldiers and i<j.
    /// Return the indices of the k weakest rows in the matrix ordered from weakest to strongest.
    /// </remarks>
    internal sealed class TheKWeakestRowsinaMatrix_1337
    {
        /// <summary>
        /// We can split the solution for two steps:
        /// 1. Find amount of 1's in every row
        /// 2. Sort the rows by 1's and then by index
        /// The first idea which came to my mind is LINQ.
        /// </summary>
        /// <param name="mat"> Input array </param>
        /// <param name="k"> Values to return </param>
        /// <returns> Indices of the k weakest rows in the matrix ordered from weakest to strongest. </returns>
        /// <remarks>
        /// Time complexity: O(n*log(n))
        /// Space complexity: O(n)
        /// </remarks>
        public int[] KWeakestRowsLinq(int[][] mat, int k)
        {
            var result = new List<Tuple<int, int>>();

            for (var i = 0; i < mat.Length; ++i)
            {
                var count = mat[i].Count(x => x == 1);

                result.Add(new Tuple<int, int>(count, i));
            }

            return result.OrderBy(x => x.Item1).ThenBy(x => x.Item2).Take(k).Select(x => x.Item2).ToArray();
        }

        /// <summary>
        /// The second solution is the 'ideal' how it should be solved. The same idea but realized all by own:
        /// 1. We use PriorityQueue with custom comparer to store rows in order
        /// 2. BinarySearch for calculating amount of 1's in the row
        /// </summary>
        /// <param name="mat"> Input array </param>
        /// <param name="k"> Values to return </param>
        /// <returns> Indices of the k weakest rows in the matrix ordered from weakest to strongest. </returns>
        /// <remarks>
        /// Time complexity: O(n*log(n))
        /// Space complexity: O(n)
        /// </remarks>
        public int[] KWeakestRowsQueue(int[][] mat, int k)
        {
            var queue = new PriorityQueue<int, int[]>(Comparer<int[]>.Create((a, b) => a[1] == b[1] ? a[0].CompareTo(b[0]) : a[1].CompareTo(b[1])));

            for (var i = 0; i < mat.Length; ++i)
            {
                var count = BinarySearch(mat[i]);

                queue.Enqueue(i, new[] { i, count });
            }

            var result = new int[k];

            for (var i = 0; i < k; ++i)
            {
                result[i] = queue.Dequeue();
            }

            return result;
        }

        /// <summary>
        /// Supported void to find amount of 1's
        /// </summary>
        /// <param name="row"> Row </param>
        /// <returns> Amount of 1's </returns>
        private int BinarySearch(int[] row)
        {
            if (row[0] == 0)
            {
                return 0;
            }

            if (row[row.Length - 1] == 1)
            {
                return row.Length;
            }

            var leftIndex = 0;
            var rightIndex = row.Length - 1;

            while (leftIndex <= rightIndex)
            {
                var middle = leftIndex + (rightIndex - leftIndex) / 2;

                if (row[middle] == 0 && row[middle - 1] == 1)
                {
                    return middle;
                }

                if (row[middle] == 0)
                {
                    rightIndex = middle - 1;
                }
                else
                {
                    leftIndex = middle + 1;
                }
            }

            return leftIndex + 1;
        }
    }
}
