namespace LeetCodeNet.Medium.Array
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length
    /// </summary>
    /// <remarks>
    /// Given a string s and an integer k, return the maximum number of vowel letters in any substring of s with length k.
    /// Vowel letters in English are 'a', 'e', 'i', 'o', and 'u'.
    /// </remarks>
    internal sealed class MaximumNumberofVowelsinaSubstringofGivenLength_1456
    {
        /// <summary>
        /// We need to check the substring of specified length (k), so we can track it using the sliding window technique.
        /// The left pointer is the current index - k, the right pointer is the current index. So, if we have an input string 'leetcode' with a sliding length equal to 3, then:
        /// Step 1. Left pointer = 0, Right pointer = -3, Left char = 'l', Right char = empty. Window = 'l', Current result (of sliding window) = 0, Max result = 0
        /// Step 2. Left pointer = 1, Right pointer = -2, Left char = 'e', Right char = empty. Window = 'le', Current result = 1, Max result = 1
        /// Step 3. Left pointer = 2, Right pointer = -1, Left char = 'e', Right char = empty. Window = 'lee', Current result = 2, Max result = 2
        /// Step 4. Left pointer = 3, Right pointer = 0, Left char = 't', Right char = 'l'. Window = 'eet', Current result = 2, Max result = 2
        /// Step 5. Left pointer = 4, Right pointer = 1, Left char = 'c', Right char = 'e'. Window = 'etc', Current result = 1, Max result = 2
        /// Step 6. Left pointer = 5, Right pointer = 2, Left char = 'o', Right char = 'e'. Window = 'tco', Current result = 1, Max result = 2
        /// Etc.
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <param name="k"> Length </param>
        /// <returns> Maximum number of vowel letters </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public int MaxVowelsSimple(string s, int k)
        {
            var curResult = 0;
            var vowels = new[] { 'a', 'e', 'i', 'o', 'u' };

            for (var i = 0; i < k; ++i)
            {
                if (vowels.Contains(s[i]))
                {
                    ++curResult;
                }
            }

            var maxResult = curResult;
            var leftIndex = 0;

            for (var rightIndex = k; rightIndex < s.Length; ++rightIndex)
            {
                if (vowels.Contains(s[leftIndex]))
                {
                    --curResult;
                }

                if (vowels.Contains(s[rightIndex]))
                {
                    ++curResult;
                }

                maxResult = Math.Max(curResult, maxResult);

                ++leftIndex;
            }

            return maxResult;
        }

        /// <summary>
        /// The same idea but in the shorter variant.
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <param name="k"> Length </param>
        /// <returns> Maximum number of vowel letters </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public int MaxVowelsOptimized(string s, int k)
        {
            var curResult = 0;
            var maxResult = 0;
            var vowels = new[] { 'a', 'e', 'i', 'o', 'u' };

            for (var i = 0; i < s.Length; ++i)
            {
                if (vowels.Contains(s[i]))
                {
                    ++curResult;
                }

                if (i >= k && vowels.Contains(s[i - k]))
                {
                    --curResult;
                }

                maxResult = Math.Max(curResult, maxResult);
            }

            return maxResult;
        }
    }
}
