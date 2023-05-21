using System.Text;

namespace LeetCodeNet.Easy.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/lexicographically-smallest-palindrome
    /// </summary>
    /// <remarks>
    /// You are given a string s consisting of lowercase English letters, and you are allowed to perform operations on it. In one operation, you can replace a character in s with another lowercase English letter.
    /// Your task is to make s a palindrome with the minimum number of operations possible.If there are multiple palindromes that can be made using the minimum number of operations, make the lexicographically smallest one.
    /// A string a is lexicographically smaller than a string b (of the same length) if in the first position where a and b differ, string a has a letter that appears earlier in the alphabet than the corresponding letter in b.
    /// Return the resulting palindrome string.
    /// </remarks>
    internal sealed class MinimumStringLengthAfterRemovingSubstrings_2696
    {
        /// <summary>
        /// We can use a two-pointers approach here.Let's start with two pointers, one at the beginning of the string and the other at the end.
        ///   * If the characters at the two pointers are the same, we move the pointers towards each other;
        ///   * If the characters are different, we replace the character at pointers with the lexicographically smaller of the two characters.Then, we move the pointers towards each other.
        /// Like, for 'egcfe' we get:
        ///   * Step 1. Left pointer = 0, right pointer = 4, e == e
        ///   * Step 2. Left pointer = 1, right pointer = 3, g != f, f<g
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <returns> Palindrome </returns>
        /// <remarks>
        /// Time complexity: O(log(n))
        /// Space complexity: O(n)
        /// </remarks>
        public string MakeSmallestPalindrome(string s)
        {
            var result = new StringBuilder(s);

            for (var i = 0; i < s.Length / 2; ++i)
            {
                var leftIndex = i;
                var rightIndex = s.Length - i - 1;

                if (result[leftIndex] == result[rightIndex])
                {
                    continue;
                }

                if (result[leftIndex] < result[rightIndex])
                {
                    result[rightIndex] = result[leftIndex];
                }
                else
                {
                    result[leftIndex] = result[rightIndex];
                }
            }

            return result.ToString();
        }
    }
}
