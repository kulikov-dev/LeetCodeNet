namespace LeetCodeNet.Easy.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/isomorphic-strings
    /// </summary>
    /// <remarks>
    /// Given two strings s and t, determine if they are isomorphic.
    /// Two strings s and t are isomorphic if the characters in s can be replaced to get t.
    /// All occurrences of a character must be replaced with another character while preserving the order of characters.No two characters may map to the same character, but a character may map to itself.
    /// </remarks>
    internal sealed class IsomorphicStrings_205
    {
        /// <summary>
        /// We're going to use two arrays to store matching between two strings.
        /// The second array need to prevent map of two characters to the same character.
        /// S = foo, T = bar
        /// Step 1. ArrayS['f'] = 'b'
        ///         ArrayT['b'] = 'f'
        /// Step 2. ArrayS['o'] = 'a'
        ///         ArrayT['a'] = 'o'
        /// Step 3. ArrayS['o'] == 'a', however in T we have 'r', return false
        /// </summary>
        /// <param name="s"> Input string 1 </param>
        /// <param name="t"> Input string 2 </param>
        /// <returns> True, if isomorphic </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(1), as we use constant count of arrays
        /// </remarks>
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            //// As we have in ASCII set only 128 symbols, this will be enough
            var charMatchS = Enumerable.Repeat(-1, 128).ToArray();
            var charMatchT = Enumerable.Repeat(-1, 128).ToArray();

            for (var i = 0; i < s.Length; i++)
            {
                if (charMatchS[s[i]] == -1)
                {
                    if (charMatchT[t[i]] != -1)
                    {
                        return false;
                    }

                    charMatchS[s[i]] = t[i];
                    charMatchT[t[i]] = s[i];
                } else if (charMatchS[s[i]] != t[i])
                {
                    return false;
                }
            }

            return true;

        }
    }
}
