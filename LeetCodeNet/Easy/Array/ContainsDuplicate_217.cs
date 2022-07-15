namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/contains-duplicate/
    /// </summary>
    /// <remarks> Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct. </remarks>
    public sealed class ContainsDuplicate_217
    {
        /// <summary>
        /// The simple approach is to use LINQ to remove all repeated values. Then we just need to compare length of both arrays.
        /// </summary>
        /// <param name="nums"> Array </param>
        /// <returns> Flag if has duplicates </returns>
        /// <remarks>
        /// Time complexity: O(N) (for linq Distinct as it use hashing)
        /// Space complexity: O(N)
        /// More info about LINQ methods complexity: https://stackoverflow.com/questions/2799427/what-guarantees-are-there-on-the-run-time-complexity-big-o-of-linq-methods
        /// </remarks>
        public bool ContainsDuplicateLinq(int[] nums)
        {
            var distinctedList = nums.Distinct();
            return distinctedList.Count() != nums.Length;
        }

        /// <summary>
        /// Use hashset to store all values of array here. It's more efficient to use hashset, as it provides fast searching.
        /// </summary>
        /// <param name="nums"> Array </param>
        /// <returns> Flag if has duplicates </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(N)
        /// </remarks>
        public bool ContainsDuplicateHash(int[] nums)
        {
            var hash = new HashSet<int>();
            foreach (var num in nums)
            {
                if (hash.Contains(num))
                {
                    return true;
                }

                hash.Add(num);
            }

            return false;
        }

        /// <summary>
        /// Idea is to sort array first. And then compare current and previous value. If equal, then it's duplicates
        /// </summary>
        /// <param name="nums"> Array </param>
        /// <returns> Flag if has duplicates </returns>
        /// <remarks>
        /// Time complexity: O(N log N)
        /// Space complexity: O(1)
        /// </remarks>
        public bool ContainsDuplicateSorting(int[] nums)
        {
            //// It's necessary to create a new variable, as the array was passed by reference.
            /// It's not a good idea to change source array.
            var sortedNums = nums.OrderBy(x => x).ToArray();
            for (var i = 1; i < sortedNums.Length; ++i)
            {
                if (sortedNums[i - 1].Equals(sortedNums[i]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}