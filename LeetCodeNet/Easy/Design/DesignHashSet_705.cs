namespace LeetCodeNet.Easy.Design
{
    /// <summary>
    /// https://leetcode.com/problems/design-hashset/
    /// </summary>
    /// <remarks> Design a HashSet without using any built-in hash table libraries. </remarks>
    public class MyHashSet_Easy
    {
        //// Most obvious solution (which is good btw): one-dimension array of booleans, which detects do we have value with this index or not.
        /// so, _set[5] = true indicates that we have value 5.

        /// <summary>
        /// Array to store hashset values
        /// </summary>
        /// <remarks> We use this count because of value constraints: from 0 to 10^6 </remarks>
        private bool[] _set = new bool[1000001];

        /// <summary>
        /// Add value to the hashset
        /// </summary>
        /// <param name="key"> New value </param>
        public void Add(int key)
        {
            _set[key] = true;
        }

        /// <summary>
        /// Remove value from the hashset
        /// </summary>
        /// <param name="key"> Value to remove </param>
        public void Remove(int key)
        {
            _set[key] = false;
        }

        /// <summary>
        /// Check if the hashset contains value
        /// </summary>
        /// <param name="key"> Value to check </param>
        /// <returns> True, if contains </returns>
        public bool Contains(int key)
        {
            return _set[key];
        }
    }

    /// <summary>
    /// https://leetcode.com/problems/design-hashset/
    /// </summary>
    /// <remarks> Design a HashSet without using any built-in hash table libraries. </remarks>
    public class MyHashSet_Optimal
    {
        //// The similar idea, but we try to do it more optimized: let's use the idea from 'phone book' problem.
        /// We will store array of pages (with 10k pages according to constraints) and each page will contain 10k elements

        /// <summary>
        /// Pages count
        /// </summary>
        private const int PagesCount = 10000;

        /// <summary>
        /// Pages-values to store.
        /// </summary>
        private readonly bool[][] _set = new bool[PagesCount][];

        /// <summary>
        /// Add value to the hashset
        /// </summary>
        /// <param name="key"> New value </param>
        public void Add(int key)
        {
            var pageIndex = GetPageIndex(key);


            _set[pageIndex][GetIndexOnPage(key, pageIndex)] = true;
        }

        /// <summary>
        /// Remove value from the hashset
        /// </summary>
        /// <param name="key"> Value to remove </param>
        public void Remove(int key)
        {
            var pageIndex = GetPageIndex(key);
            _set[pageIndex][GetIndexOnPage(key, pageIndex)] = false;
        }

        /// <summary>
        /// Check if the hashset contains value
        /// </summary>
        /// <param name="key"> Value to check </param>
        /// <returns> True, if contains </returns>
        public bool Contains(int key)
        {
            var pageIndex = GetPageIndex(key);

            return _set[pageIndex][GetIndexOnPage(key, pageIndex)];
        }

        /// <summary>
        /// Get page index and create new page if necessary 
        /// </summary>
        /// <param name="key"> Value </param>
        /// <returns> Page index </returns>
        private int GetPageIndex(int key)
        {
            //// We initialize new arrays only if necessary
            var pageIndex = (int)(key / PagesCount);

            _set[pageIndex] ??= new bool[PagesCount];

            return pageIndex;
        }

        /// <summary>
        /// Get index of element in the page
        /// </summary>
        /// <param name="key"> Value </param>
        /// <param name="pageIndex"> Page index </param>
        /// <returns> Element index in the page </returns>
        private int GetIndexOnPage(int key, int pageIndex)
        {
            return key - pageIndex * PagesCount;
        }
    }
}
