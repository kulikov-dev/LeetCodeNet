namespace LeetCodeNet.Easy.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/minimize-string-length
    /// </summary>
    /// <remarks>
    /// Given a 0-indexed string s, repeatedly perform the following operation any number of times:
    /// Choose an index i in the string, and let c be the character in position i.Delete the closest occurrence of c to the left of i (if any) and the closest occurrence of c to the right of i(if any).
    /// Your task is to minimize the length of s by performing the above operation any number of times.
    /// Return an integer denoting the length of the minimized string.
    /// </remarks>
    internal sealed class MinimizeStringLength_2716
    {
        /// <summary>
        /// If we rephrase the task, we understand that the goal of this problem is to count all unique characters. So, we can use any suitable solution to find it out
        /// Here is a hashset solution
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <returns> Length of the minimized string </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public int MinimizedStringLengthHash(string s)
        {
            var hash = new HashSet<char>();

            for (var i = 0; i < s.Length; i++)
            {
                hash.Add(s[i]);
            }

            return hash.Count;
        }

        /// <summary>
        /// And LINQ+group by solution
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <returns> Length of the minimized string </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public int MinimizedStringLengthLinq(string s)
        {
            return s.Select(item => item).GroupBy(item => item).Count();
        }
    }
}
