namespace LeetCodeNet.Medium.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/permutation-in-string/
    /// </summary>
    /// <remarks>
    /// Given two strings s1 and s2, return true if s2 contains a permutation of s1, or false otherwise.
    /// In other words, return true if one of s1's permutations is the substring of s2.
    /// </remarks>
    internal sealed class PermutationinString_567
    {
        /// <summary>
        /// Think of this task as a special case of the anagram task. We need to check if s2 contains the anagram of s1.
        /// This can be done by finding all the substrings of length same as s1 and check that substring is anagram or not.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(1)
        /// </remarks>
        public bool CheckInclusion(string s1, string s2)
        {
            if (s2.Length < s1.Length)
            {
                return false;
            }

            var dict = new int[26];

            for (var i = 0; i < s1.Length; i++)
            {
                dict[s1[i] - 'a']++;
                dict[s2[i] - 'a']--;
            }

            if (dict.All(x => x == 0))
            {
                return true;
            }

            for (var i = s1.Length; i < s2.Length; ++i)
            {
                dict[s2[i] - 'a']--;
                dict[s2[i - s1.Length] - 'a']++;

                if (dict.All(x => x == 0))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
