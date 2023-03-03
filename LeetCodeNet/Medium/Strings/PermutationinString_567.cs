namespace LeetCodeNet.Medium.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/permutation-in-string/
    /// </summary>
    /// <remarks>
    /// Given two strings s1 and s2, return true if s2 contains a permutation of s1, or false otherwise.
    /// In other words, return true if one of s1's permutations is the substring of s2.
    /// </remarks>
    public sealed class PermutationinString_567
    {
        /// <summary>
        /// Think of this task as a special case of the anagram task. We need to check if s2 contains the anagram of s1.
        /// This can be done by finding all the substrings of length same as s1 and check that substring is anagram or not.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public bool CheckInclusion(string s1, string s2)
        {
            if (s2.Length < s1.Length)
            {
                return false;
            }

            var dict = new Dictionary<char, int>(26);

            for (var i = 0; i < s1.Length; i++)
            {
                if (!dict.ContainsKey(s1[i]))
                {
                    dict.Add(s1[i], 0);
                }

                dict[s1[i]]++;

                if (!dict.ContainsKey(s2[i]))
                {
                    dict.Add(s2[i], 0);
                }

                dict[s2[i]]--;
            }

            if (dict.All(x => x.Value == 0))
            {
                return true;
            }

            for (var i = s1.Length; i < s2.Length; ++i)
            {
                if (!dict.ContainsKey(s2[i]))
                {
                    dict.Add(s2[i], 0);
                }

                dict[s2[i]]--;

                dict[s2[i - s1.Length]]++;

                if (dict.All(x => x.Value == 0))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
