using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeNet.Easy.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/is-subsequence
    /// </summary>
    /// <remarks>
    ///Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
    /// A subsequence of a string is a new string that is formed from the original string by deleting some(can be none) of the characters without disturbing the relative positions of the remaining characters.
    /// (i.e., "ace" is a subsequence of "abcde" while "aec" is not).
    /// </remarks>
    internal sealed class IsSubsequence_392
    {
        /// <summary>
        /// Use two pointers approach where we skip all characters in T to preserve S chars order
        /// </summary>
        /// <param name="s"> Input S </param>
        /// <param name="t"> Input T </param>
        /// <returns> True if S is subsequence of T </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(1)
        /// </remarks>
        public bool IsSubsequence(string s, string t)
        {
            var tPointer = 0;

            for (var sPointer = 0; sPointer < s.Length; sPointer++)
            {
                while (tPointer < t.Length && t[tPointer] != s[sPointer])
                {
                    ++tPointer;
                }

                if (tPointer == t.Length)
                {
                    return false;
                }

                ++tPointer;
            }

            return true;
        }
    }
}
