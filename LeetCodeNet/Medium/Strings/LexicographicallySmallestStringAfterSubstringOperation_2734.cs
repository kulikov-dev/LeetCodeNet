using System.Text;

namespace LeetCodeNet.Medium.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/lexicographically-smallest-string-after-substring-operation/
    /// </summary>
    /// <remarks>
    /// You are given a string s consisting of only lowercase English letters. In one operation, you can do the following:
    /// Select any non-empty substring of s, possibly the entire string, then replace each one of its characters with the previous character of the English alphabet.For example, 'b' is converted to 'a', and 'a' is converted to 'z'.
    /// Return the lexicographically smallest string you can obtain after performing the above operation exactly once.
    /// A substring is a contiguous sequence of characters in a string.
    /// A string x is lexicographically smaller than a string y of the same length if x[i] comes before y[i] in alphabetic order for the first position i such that x[i] != y[i].
    /// </remarks>
    internal sealed class LexicographicallySmallestStringAfterSubstringOperation_2734
    {
        /// <summary>
        /// There are two cases for this problem:
        /// 1. Where all lines contain 'a', so we need to change the last symbol to 'z' to keep lexicographic order.
        /// 2. To reduce lexicographic order, we need to find the first substring with the following conditions:
        ///   a. Starts from any symbol that differs from 'a'
        ///   b. Ends with any symbol that differs from 'a.
        /// Like: abbaz -> aaaaz
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <returns> Lexicographically smaller string </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public string SmallestString(string s)
        {
            if (s.Length == 0)
            {
                return s;
            }

            var result = new StringBuilder(s);

            var hasAnyExceptA = false;

            for (var i = 0; i < s.Length; i++)
            {
                if (result[i] != 'a')
                {
                    hasAnyExceptA = true;
                    result[i] = (char)(result[i] - 1);
                }
                else if (hasAnyExceptA)
                {
                    break;
                }
            }

            if (!hasAnyExceptA)
            {
                result[^1] = 'z';
            }

            return result.ToString();
        }
    }
}
