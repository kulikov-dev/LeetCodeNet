namespace LeetCodeNet.Medium.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/longest-substring-without-repeating-characters/
    /// </summary>
    /// <remarks> Given a string s, find the length of the longest substring without repeating characters. </remarks>
    public class LongestSubstringWithoutRepeatingCharacters_3
    {
        /// <summary>
        /// Idea is to create a dictionary, which stores the character and it's position. We update position each time, when find duplicated char.
        /// Now we can use sliding window approach, where i - is the index for each char. And 'lastIndex' is the index of the last non-repeatable char.
        /// The trick here is to correct process situations for 'abba'. Where for second 'a' we get the index 1, but here is another duplicated char.
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <returns> Length of the longest substring without repeating </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(N)
        /// </remarks>
        public int LengthOfLongestSubstring(string s)
        {
            var result = 0;
            var lastIndex = 0;
            var dict = new Dictionary<char, int>();

            for (var i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                {
                    dict.Add(s[i], i);
                }
                else
                {
                    lastIndex = Math.Max(lastIndex, dict[s[i]] + 1);            // The trick
                    dict[s[i]] = i;
                }

                result = Math.Max(result, i - lastIndex + 1);
            }

            return result;
        }
    }
}
