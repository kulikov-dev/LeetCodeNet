namespace LeetCodeNet.Easy.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/first-unique-character-in-a-string/
    /// </summary>
    /// <remarks>
    /// Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.
    /// </remarks>
    internal sealed class FirstUniqueCharacterinaString_387
    {
        /// <summary>
        /// Approach is to use hashset/array to store char and it's amount in S
        /// The second pass needs to find first char where amount equals to 1
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <returns> Index of the first non-repepating char </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1), as we need only array with constant size
        /// </remarks>
        public int FirstUniqCharArray(string s)
        {
            var alphabet = new int[26];
            //// First pass to find all amounts of chars
            for (var i = 0; i < s.Length; ++i)
            {
                //// Char manipulation on ASCII codes. As 'a' = 97 in ASCII, so we need to substract 'a' to get the real position in alphabet
                ++alphabet[s[i] - 'a'];
            }

            //// Second pass to find first non-repeating character
            for (var i = 0; i < s.Length; ++i)
            {
                if (alphabet[s[i] - 'a'] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
