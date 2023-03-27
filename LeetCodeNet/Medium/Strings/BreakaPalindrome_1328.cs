using System.Text;

namespace LeetCodeNet.Medium.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/break-a-palindrome/
    /// </summary>
    /// <remarks>
    /// Given a palindromic string of lowercase English letters palindrome, replace exactly one character with any lowercase English letter so that the resulting string is not a palindrome and that
    /// it is the lexicographically smallest one possible.
    /// Return the resulting string. If there is no way to replace a character to make it not a palindrome, return an empty string.
    /// A string a is lexicographically smaller than a string b(of the same length) if in the first position where a and b differ, a has a character strictly smaller than the corresponding character in b.
    /// For example, "abcc" is lexicographically smaller than "abcd" because the first position they differ is at the fourth character, and 'c' is smaller than 'd'.
    /// </remarks>
    internal sealed class BreakaPalindrome_1328
    {
        /// <summary>
        /// 1. We need to check if it's a 1-length string. In ALL cases 1-length string will be a palindrome. So, we can't make it non-palindrome string
        /// 2. Go through the string and check if there any non-'a' char, so we can replace it to 'b' (next lexicographically smallest char).
        /// We can optimize iterating only for the half of the string, as it is a palindrome
        /// 3. Last one. Situation where all string consists of 'a' chars. So, we just change the last symbol.
        /// Trick here is to take into account the string like 'aba'. If we just change b to a - we will get the palindrome.
        /// P.S. StringBuilder make it optimal to work with the string
        /// </summary>
        /// <param name="palindrome"> Palindrome </param>
        /// <returns> Non-palindrome string </returns>
        /// <remarks>
        /// Time complexity: O(log N)
        /// Space complexity: O(N)
        /// </remarks>
        public string BreakPalindrome(string palindrome)
        {
            if (palindrome.Length == 1)
            {
                return string.Empty;
            }

            var result = new StringBuilder(palindrome);

            for (var i = 0; i < result.Length / 2; i++)
            {
                if (result[i] != 'a')
                {
                    result[i] = 'a';

                    return result.ToString();
                }
            }

            result[result.Length - 1] = 'b';

            return result.ToString();
        }
    }
}
