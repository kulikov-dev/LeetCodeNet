using System.Text;

namespace LeetCodeNet.Easy.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/merge-strings-alternately/
    /// </summary>
    /// <remarks>
    /// You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1.
    /// If a string is longer than the other, append the additional letters onto the end of the merged string.
    /// </remarks>
    internal sealed class MergeStringsAlternately_1768
    {
        /// <summary>
        /// No specific algorithm, merging arrays through one pass step by step
        /// </summary>
        /// <param name="word1"> Word 1 </param>
        /// <param name="word2"> Word 2 </param>
        /// <returns> Merged string </returns>
        /// <remarks>
        /// Time complexity: O(n+m)
        /// Space complexity: O(n+m)
        /// </remarks>
        public string MergeAlternately(string word1, string word2)
        {
            var sb = new StringBuilder(word1.Length + word2.Length);
            //// Find word with minimum length to prevent index outside the bounds
            var minLength = Math.Min(word1.Length, word2.Length);

            for (var i = 0; i < minLength; ++i)
            {
                //// Append characters from two words
                sb.Append(word1[i]);
                sb.Append(word2[i]);
            }

            //// Check situation if one word is longer than another
            if (word1.Length > minLength)
            {
                sb.Append(word1.Skip(minLength).ToArray());
            }
            else if (word2.Length > minLength)
            {
                sb.Append(word2.Skip(minLength).ToArray());
            }

            return sb.ToString();
        }
    }
}