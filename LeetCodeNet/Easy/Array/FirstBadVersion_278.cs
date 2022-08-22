namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/first-bad-version/
    /// </summary>
    /// <remarks> You are a product manager and currently leading a team to develop a new product. Unfortunately, the latest version of your product fails the quality check. Since each version is developed based on the previous version, all the versions after a bad version are also bad.
    /// Suppose you have n versions[1, 2, ..., n] and you want to find out the first bad one, which causes all the following ones to be bad.
    /// You are given an API bool isBadVersion(version) which returns whether version is bad.Implement a function to find the first bad version.You should minimize the number of calls to the API.
    /// Great explanation is here: https://leetcode.com/problems/search-insert-position/discuss/423166/Binary-Search-101
    /// </remarks>
    public sealed class FirstBadVersion_278
    {
        /// <summary>
        /// All this "versions" is a simple sorted array. So, if you see 'sorted array' and the task connected with searching - the best approach is to use Binary Search
        /// </summary>
        /// <param name="n"> Last version number </param>
        /// <param name="checker"> API checker </param>
        /// <returns></returns>
        /// <remarks>
        /// Time complexity: O(log n)
        /// Space complexity: O(1)
        /// </remarks>
        public int FirstBadVersion(int n, IBadVersionChecker checker)
        {
            var leftPointer = 0;
            var rightPointer = n;
            while (leftPointer < rightPointer)
            {
                //// Check if current middle position is bad - then go left to find earlier bad version
                /// In other case - go to right and find first bad version
                var middlePointer = leftPointer + (rightPointer - leftPointer) / 2;
                var isBadVersion = checker.IsBadVersion(middlePointer);
                if (isBadVersion)
                {
                    rightPointer = middlePointer;
                }
                else
                {
                    leftPointer = middlePointer + 1;
                }
            }

            return leftPointer;
        }
    }

    /// <summary>
    /// Interface for an API tool
    /// </summary>
    public interface IBadVersionChecker
    {
        /// <summary>
        /// Check if version is bad
        /// </summary>
        /// <param name="version"> Current version </param>
        /// <returns> Flag if bad</returns>
        bool IsBadVersion(int version);
    }
}