namespace LeetCodeNet.Tests.Easy.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/valid-anagram/
    /// </summary>
    /// <remarks>
    /// Given two strings s and t, return true if t is an anagram of s, and false otherwise.
    /// </remarks>
    internal sealed class ValidAnagram_242
    {
        /// <summary>
        /// First idea is to sort both words and compare them char by char
        /// </summary>
        /// <param name="s"> Word 1 </param>
        /// <param name="t"> Word 2 </param>
        /// <returns> Flag if word2 is anagram of word1 </returns>
        /// <remarks>
        /// Time complexity: O(n log(n))
        /// Space complexity: O(1)
        /// </remarks>
        public bool IsAnagramSorting(string s, string t)
        {
            //// Prevent useless operation by simple check - if lengths are different - the word2 is not an anagram.
            if (s.Length != t.Length)
            {
                return false;
            }

            var sortedS = s.OrderBy(x => x).ToArray();
            var sortedT = t.OrderBy(x => x).ToArray();

            return sortedS.SequenceEqual(sortedT);
        }

        /// <summary>
        /// The second way is to use hash for storing all chars and it's amounts of word1.
        /// The second pass throught word2 to decrease char amounts
        /// If has no char in hash or after passing - we have positive amounts, it means that word2 is not an anagram.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public bool IsAnagramHash(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            //// Create hash table with char - it's amount for first word
            var dict = new Dictionary<char, int>();

            for (var i = 0; i < s.Length; ++i)
            {
                if (!dict.ContainsKey(s[i]))
                {
                    dict.Add(s[i], 0);
                }

                ++dict[s[i]];
            }

            //// Decrease each char's amount in second word
            foreach (var tChar in t)
            {
                if (!dict.ContainsKey(tChar))
                {
                    return false;
                }

                --dict[tChar];
            }

            return dict.Values.All(x => x == 0);
        }
    }
}