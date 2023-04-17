namespace LeetCodeNet.Medium.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/longest-repeating-character-replacement
    /// </summary>
    /// <remarks>
    /// You are given a string s and an integer k. You can choose any character of the string and change it to any other uppercase English character. You can perform this operation at most k times.
    /// Return the length of the longest substring containing the same letter you can get after performing the above operations.
    /// </remarks>
    internal sealed class LongestRepeatingCharacterReplacement_424
    {
        /// <summary>
        /// It's an issue of sliding window.
        /// We create left/right indexes as well as array with most frequent char in this substring
        /// Those for each step we can calc the amount of chars that needs to be changed, like:
        /// charToChange = (length of substring - most_frequent_char in the substring)
        /// If charToChange > k, than we can move our sliding window
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <param name="k"> Chars to replace </param>
        /// <returns> Length of longest string </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(1)
        /// </remarks>
        public int CharacterReplacement(string s, int k)
        {
            var mostFrequentLetter = 0;
            var frequentLetters = new int[33];

            var left = 0;
            var result = 0;

            for (var right = 0; right < s.Length; ++right)
            {
                var currentCharIndex = s[right] - 'A';

                frequentLetters[currentCharIndex]++;
                if (frequentLetters[mostFrequentLetter] < frequentLetters[currentCharIndex])
                {
                    mostFrequentLetter = currentCharIndex;
                }

                if (right - left + 1 - frequentLetters[mostFrequentLetter] > k)
                {
                    --frequentLetters[s[left] - 'A'];
                    ++left;
                }
                else
                {
                    result = Math.Max(result, right - left + 1);
                }
            }

            return result;
        }
    }
}
