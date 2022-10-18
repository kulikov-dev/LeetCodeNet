namespace LeetCodeNet.Easy.BitManipulation
{
    /// <summary>
    /// https://leetcode.com/problems/sort-integers-by-the-number-of-1-bits/
    /// </summary>
    /// <remarks>
    /// You are given an integer array arr. Sort the integers in the array in ascending order by the number of 1's in their binary representation and in case of two or more integers have the same number of 1's 
    /// you have to sort them in ascending order. Return the array after sorting it.
    /// </remarks>
    public sealed class SortIntegersbyTheNumberof1Bits_1356
    {
        /// <summary>
        /// Idea for this task is to calc hamilton weight for each element. After that we can sort first: by bits count. Second: by elements with same bits count
        /// </summary>
        /// <param name="arr"> Input array </param>
        /// <returns> Sorted array </returns>
        /// <remarks>
        /// Time complexity: O(n*log(n))
        /// Space complexity: O(n)
        /// </remarks>
        public int[] SortByBitsLinq(int[] arr)
        {
            var source = new List<Tuple<int, int>>();
            foreach (var item in arr)
            {
                var bitsCount = CalcHamiltonWeight(item);

                source.Add(Tuple.Create(item, bitsCount));
            }

            return source.OrderBy(item => item.Item2).ThenBy(item => item.Item1).Select(item => item.Item1).ToArray();
        }

        /// <summary>
        /// The same idea is to calc hamilton weight first. Then we will use not possible value (10 001 by the task) to create unique array for sorting.
        /// </summary>
        /// <param name="arr"> Input array </param>
        /// <returns> Sorted array </returns>
        /// <remarks>
        /// Time complexity: O(n*log(n))
        /// Space complexity: O(n)
        /// </remarks>
        public int[] SortByBitsData(int[] arr)
        {
            const int notPossibleValue = 10001;     // By the task input values can be from 0 to 10 000, so we can take 10 001 as not possible value for sorting purpose.
            var source = new List<int>();
            foreach (var item in arr)
            {
                var bitsCount = CalcHamiltonWeight(item);

                source.Add((bitsCount * notPossibleValue) + item);
            }

            source.Sort();
            return source.Select(x => x % notPossibleValue).ToArray();
        }

        /// <summary>
        /// Supporting function to calc hamilton weight (which equals bits count)
        /// </summary>
        /// <param name="value"> Number </param>
        /// <returns> Bits count </returns>
        private int CalcHamiltonWeight(int value)
        {
            var temp = value;
            var bitsCount = 0;
            while (temp != 0)
            {
                bitsCount += (temp & 1) == 1 ? 1 : 0;
                temp >>= 1;
            }

            return bitsCount;
        }
    }
}
