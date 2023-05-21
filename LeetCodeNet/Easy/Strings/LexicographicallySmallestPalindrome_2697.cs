using System.Text;

namespace LeetCodeNet.Easy.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-string-length-after-removing-substrings
    /// </summary>
    /// <remarks>
    /// You are given a string s consisting only of uppercase English letters.
    /// You can apply some operations to this string where, in one operation, you can remove any occurrence of one of the substrings "AB" or "CD" from s.
    /// Return the minimum possible length of the resulting string that you can obtain. Note that the string concatenates after removing the substring and could produce new "AB" or "CD" substrings.
    /// </remarks>
    internal sealed class LexicographicallySmallestPalindrome_2697
    {
        /// <summary>
        /// We can use greedy approach here. We iterate through the string s and whenever we encounter either 'A' or 'C', we check if the next character is 'B' or 'D' respectively.
        /// If we find a match, we skip these two characters and continue iterating. Otherwise, we append the current character to a result string until no matches are found.
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <returns></returns>
        /// <remarks>
        /// Time complexity: O(2^n)
        /// Space complexity: O(1)
        /// </remarks>
        public int MinLength(string s)
        {
            var result = new StringBuilder(s.Length);

            for (var i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1 && ((s[i] == 'A' && s[i + 1] == 'B') || (s[i] == 'C' && s[i + 1] == 'D')))
                {
                    ++i;
                }
                else
                {
                    result.Append(s[i]);
                }
            }

            return result.Length == s.Length ? result.Length : MinLength(result.ToString());
        }
    }
}
