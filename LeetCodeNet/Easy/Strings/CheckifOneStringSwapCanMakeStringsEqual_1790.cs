namespace LeetCodeNet.Easy.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/check-if-one-string-swap-can-make-strings-equal/
    /// </summary>
    /// <remarks>
    /// You are given two strings s1 and s2 of equal length. A string swap is an operation where you choose two indices in a string (not necessarily different)
    /// and swap the characters at these indices.
    /// Return true if it is possible to make both strings equal by performing at most one string swap on exactly one of the strings.Otherwise, return false.
    /// </remarks>
    internal sealed class CheckifOneStringSwapCanMakeStringsEqual_1790
    {
        /// <summary>
        /// Iterate through two strings and find all indexes of different chars. We met conditions, if we don't have difference or we have two different chars, which equals
        /// </summary>
        /// <param name="s1"> String 1 </param>
        /// <param name="s2"> String 2 </param>
        /// <returns> Flag, if possible to make both strings equal by performing at most one string swap </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public bool AreAlmostEqual(string s1, string s2)
        {
            //// Store positions of diff characters
            var diffCharPos1 = -1;
            var diffcharPos2 = -1;
            var diffCounts = 0;

            for (var i = 0; i < s1.Length; ++i)
            {
                if (s1[i] != s2[i])
                {
                    ++diffCounts;
                    if (diffCharPos1 == -1)
                    {
                        diffCharPos1 = i;
                    }
                    else
                    {
                        diffcharPos2 = i;
                    }

                    //// We can break iterations, if diff count is more than 2
                    if (diffCounts > 2)
                    {
                        return false;
                    }
                }
            }

            //// No difference or same characters are swapped
            return diffCounts == 0 || s1[diffCharPos1] == s2[diffcharPos2] && s1[diffcharPos2] == s2[diffCharPos1];
        }
    }
}