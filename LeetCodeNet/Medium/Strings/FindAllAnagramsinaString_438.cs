namespace LeetCodeNet.Medium.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/find-all-anagrams-in-a-string/
    /// </summary>
    /// <remarks>
    /// Given two strings s and p, return an array of all the start indices of p's anagrams in s. You may return the answer in any order.
    /// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
    /// </remarks>
    public class FindAllAnagramsinaString_438
    {
        /// <summary>
        /// Great explanation is here: https://leetcode.com/problems/find-all-anagrams-in-a-string/solutions/1738052/a-very-deep-explanation-solved-without-using-hashtable/?orderBy=most_votes
        /// </summary>
        /// <param name="s"> String </param>
        /// <param name="p"> Anagram string </param>
        /// <returns> Array of index of anagrams </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(1)
        /// </remarks>
        public IList<int> FindAnagrams(string s, string p)
        {
            if (p.Length > s.Length)
            {
                return new List<int>();
            }

            var result = new List<int>();
            var dict = new int[26];

            for (var i = 0; i < p.Length; i++)
            {
                dict[p[i] - 'a']++;
                dict[s[i] - 'a']--;
            }

            if (dict.All(x => x == 0))
            {
                result.Add(0);
            }

            for (var i = p.Length; i < s.Length; i++)
            {
                dict[s[i] - 'a']--;
                dict[s[i - p.Length ] - 'a']++;

                if (dict.All(x => x == 0))
                {
                    result.Add(i - p.Length + 1);
                }
            }

            return result;
        }
    }
}
