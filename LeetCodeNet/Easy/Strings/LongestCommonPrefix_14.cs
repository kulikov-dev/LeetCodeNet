using System.Text;

namespace LeetCodeNet.Easy.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/longest-common-prefix/
    /// </summary>
    /// <remarks> 
    /// Write a function to find the longest common prefix string amongst an array of strings. 
    /// If there is no common prefix, return an empty string "".
    /// </remarks>
    internal sealed class LongestCommonPrefix_14
    {
        /// <summary>
        /// Two pass: one through chars, another - through stings. Nothing special
        /// </summary>
        /// <param name="strs"> Input strings </param>
        /// <returns> Common prefix </returns>
        /// <remarks>
        /// Time complexity: O(n^2), for two loops
        /// Space complexity: O(m)
        /// </remarks>
        public string LongestCommonPrefixLoop(string[] strs)
        {
            var minLength = strs.Min(x => x.Length);
            var result = new StringBuilder(minLength);

            for (var i = 0; i < minLength; ++i)
            {
                foreach (var str in strs)
                {
                    if (str[i] != strs[0][i])
                    {
                        return result.ToString();
                    }
                }

                result.Append(strs[0][i]);
            }

            return result.ToString();
        }

        /// <summary>
        /// The better approach is to sort strings before comparing. Now we can compare just first and last strings.
        /// </summary>
        /// <param name="strs"> Input strings </param>
        /// <returns> Common prefix </returns>
        /// <remarks>
        /// Time complexity: O(n log(n)), for sorting
        /// Space complexity: O(n), to store sorted strings
        /// </remarks>
        public string LongestCommonPrefixSort(string[] strs)
        {
            var sortedStrs = strs.OrderBy(x => x).ToList();
            var first = sortedStrs[0];
            var last = sortedStrs[sortedStrs.Count - 1];

            for (var i = 0; i < first.Length; ++i)
            {
                if (first[i] != last[i])
                {
                    return first.Substring(0, i);
                }
            }

            return string.Empty;
        }
    }
}