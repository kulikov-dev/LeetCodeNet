namespace LeetCodeNet.Easy.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/count-binary-substrings/
    /// </summary>
    /// <remarks>
    /// Given a binary string s, return the number of non-empty substrings that have the same number of 0's and 1's, and all the 0's and all the 1's in these substrings are grouped consecutively.
    /// Substrings that occur multiple times are counted the number of times they occur.
    /// </remarks>
    public class CountBinarySubstrings_696
    {
        /// <summary>
        /// Kind of two pointers approach. We need to calc count of previous char and count of current char, to form susbstrings
        /// More detailed explanation here: https://leetcode.com/problems/count-binary-substrings/discuss/1172569/Short-and-Easy-w-Explanation-and-Comments-or-Keeping-Consecutive-0s-and-1s-Count-or-Beats-100
        /// </summary>
        /// <param name="s"> Input binary string </param>
        /// <returns> Count of susbstrings with equal numbers </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public int CountBinarySubstrings(string s)
        {
            var result = 0;
            if (string.IsNullOrWhiteSpace(s))
            {
                return result;
            }

            //// Count the previous type of element. So, if we have 000111 and current 'i'=4, then prevCounter = 3
            var prevCounter = 0;
            //// Count the current type of element. 'i'=4, currentCounter = 1
            var currentCounter = 1;
            for (var i = 1; i < s.Length; ++i)
            {
                if (s[i] == s[i - 1])
                {
                    ++currentCounter;
                }
                else
                {
                    //// If item change - we need to change counters
                    prevCounter = currentCounter;
                    currentCounter = 1;
                }

                //// If we have prevCounter, we can increase count of substrings, as:
                /// Match: (0)00(1)11, 0(0)01(1)1, etc.
                /// Substrings are: 01, 0011, 000111
                if (prevCounter > 0)
                {
                    --prevCounter;
                    ++result;
                }
            }

            return result;
        }
    }
}
