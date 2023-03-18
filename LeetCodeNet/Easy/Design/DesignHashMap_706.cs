namespace LeetCodeNet.Easy.Design
{
    /// <summary>
    /// https://leetcode.com/problems/design-hashmap/
    /// </summary>
    /// <remarks> Design a HashMap without using any built-in hash table libraries. </remarks>
    internal sealed class MyHashMap
    {
        //// The similar idea, like in the problem #705. Phone-bool idea, but instead of bool - we will store 'int' value with -1 as non-value (according to constraints)

        /// <summary>
        /// Pages count
        /// </summary>
        private const int PageSize = 1000;

        /// <summary>
        /// Pages-values to store.
        /// </summary>
        private readonly int[][] _values = new int[PageSize * PageSize][];

        /// <summary>
        /// Put new value to the dictionary
        /// </summary>
        /// <param name="key"> Key </param>
        /// <param name="value"> Value </param>
        public void Put(int key, int value)
        {
            var pageIndex = GetPageIndex(key);

            _values[pageIndex][GetIndexOnPage(key, pageIndex)] = value;
        }

        /// <summary>
        /// Get value from the dictionary
        /// </summary>
        /// <param name="key"> Key </param>
        /// <returns> Value </returns>
        public int Get(int key)
        {
            var pageIndex = GetPageIndex(key);

            return _values[pageIndex][GetIndexOnPage(key, pageIndex)];
        }

        /// <summary>
        /// Remove value by the key
        /// </summary>
        /// <param name="key"> Key </param>
        public void Remove(int key)
        {
            var pageIndex = GetPageIndex(key);

            _values[pageIndex][GetIndexOnPage(key, pageIndex)] = -1;
        }

        /// <summary>
        /// Get page index and create new page if necessary 
        /// </summary>
        /// <param name="key"> Value </param>
        /// <returns> Page index </returns>
        private int GetPageIndex(int key)
        {
            var index = key / PageSize;

            _values[index] ??= Enumerable.Repeat(-1, PageSize).ToArray();

            return key / PageSize;
        }

        /// <summary>
        /// Get index of element in the page
        /// </summary>
        /// <param name="key"> Value </param>
        /// <param name="pageIndex"> Page index </param>
        /// <returns> Element index in the page </returns>
        public int GetIndexOnPage(int key, int pageIndex)
        {
            return key - pageIndex * PageSize;
        }
    }
}
