namespace LeetCodeNet.Medium.DP
{
    /// <summary>
    /// https://leetcode.com/problems/longest-palindromic-subsequence/
    /// </summary>
    internal sealed class LongestPalindromicSubsequence_516
    {
        /// <summary>
        /// Recursive solution. If two ends of a string are identical, they must be included in the longest palindrome subsequence. Otherwise, the longest palindrome subsequence cannot include both ends.
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <returns> Longest palindrome length </returns>
        /// <remarks>
        /// Time complexity: O(2^n)
        /// Space complexity: O(1), excluded cost of stack of calls
        /// </remarks>
        public int LongestPalindromeSubseqRecursive(string s)
        {
            return Recursive(s, 0, s.Length - 1);
        }

        /// <summary>
        /// Helper for recursion
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <param name="leftPosition"> Left index </param>
        /// <param name="rightPosition"> Right index </param>
        /// <returns> Current length </returns>
        private int Recursive(string s, int leftPosition, int rightPosition)
        {
            if (rightPosition < leftPosition)
            {
                return 0;
            }

            if (leftPosition == rightPosition)
            {
                return 1;
            }

            if (s[leftPosition] == s[rightPosition])
            {
                return 2 + Recursive(s, leftPosition + 1, rightPosition - 1);
            }

            var result = 0;
            result = Math.Max(result, Recursive(s, leftPosition + 1, rightPosition));
            result = Math.Max(result, Recursive(s, leftPosition, rightPosition - 1));

            return result;
        }

        /// <summary>
        /// Convert it to bottom up solution 
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <returns> Longest palindrome length </returns>
        /// <remarks>
        /// Time complexity: O(n * log(n))
        /// Space complexity: O(n)
        /// </remarks>
        public int LongestPalindromeSubseqBottomUp(string s)
        {
            var dp = new int[s.Length + 1][];

            for (var i = 0; i < s.Length; ++i)
            {
                dp[i] = new int[s.Length + 1];
            }

            for (var leftPosition = s.Length - 1; leftPosition >= 0; --leftPosition)
            {
                dp[leftPosition][leftPosition] = 1;

                for (var rightPosition = leftPosition + 1; rightPosition < s.Length; ++rightPosition)
                {
                    if (s[leftPosition] == s[rightPosition])
                    {
                        dp[leftPosition][rightPosition] = 2 + dp[leftPosition + 1][rightPosition - 1];
                    }
                    else
                    {
                        dp[leftPosition][rightPosition] = Math.Max(dp[leftPosition + 1][rightPosition], dp[leftPosition][rightPosition - 1]);
                    }
                }
            }

            return dp[0][s.Length - 1];
        }

        /// <summary>
        /// Move to memorized solution
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <returns> Longest palindrome length </returns>
        /// <remarks>
        /// Time complexity: O(n * log(n))
        /// Space complexity: O(1)
        /// </remarks>
        public int LongestPalindromeSubseqBottomUpMemo(string s)
        {
            var dp = new int[s.Length + 1];

            for (var leftPosition = s.Length - 1; leftPosition >= 0; --leftPosition)
            {
                dp[leftPosition] = 1;

                var prevValue = 0;

                for (var rightPosition = leftPosition + 1; rightPosition < s.Length; ++rightPosition)
                {
                    var tmp = dp[rightPosition];

                    if (s[leftPosition] == s[rightPosition])
                    {
                        dp[rightPosition] = 2 + prevValue;
                    }
                    else
                    {
                        dp[rightPosition] = Math.Max(dp[rightPosition], dp[rightPosition - 1]);
                    }

                    prevValue = tmp;
                }
            }

            return dp[s.Length - 1];
        }
    }
}
