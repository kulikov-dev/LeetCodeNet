namespace LeetCodeNet.Medium.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/longest-palindromic-substring/
    /// </summary>
    /// <remarks> Given a string s, return the longest palindromic substring in s.</remarks>
    internal sealed class LongestPalindromicSubstring_5
    {
        /// <summary>
        /// It's a good idea to take a minute and think about what is palindrome
        /// 'aba' for example. How we can check the palindrome? Take the symbol and go for the left and right symbols for checking if they are equal
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <returns> Longest palindrome string </returns>
        public string LongestPalindrome(string s)
        {
            var result = string.Empty;

            //// Let's go through each symbol and check if it creates any palindrome with this symbol in the center
            /// So, for 'cabak' we will make these steps:
            /// 1. 'c'
            /// 2. 'a'. Then we look at the previous and next chars: 'c' and 'b'. They are not equal, so it's not a palindrome.
            /// 3. 'b'. Next, we check the preceding and following characters: 'a' and 'a'. They are equal; we have the palindrome!
            ///    But first, let's see if we can make it longer by checking the previous and next characters: "c" and "k."
            ///    No luck. So, for this case, we have the palindrome with length 3. Let's save it.
            /// 4. 'a' - etc... 
            for (var i = 0; i < s.Length; i++)
            {
                //// We need to take into account two common cases. If we have odd/even length: aba or abba.
                IsPalindrome(s, i, i, ref result);
                IsPalindrome(s, i, i + 1, ref result);

                if (result.Length == s.Length)
                {
                    break;
                }
            }

            return result;
        }

        /// <summary>
        /// Helper function to check if we can make the palindrome with center chars at left-right indexes.
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <param name="leftIndex"> Start left index </param>
        /// <param name="rightIndex"> Start right index </param>
        /// <param name="result"> Current maximum palindrome string </param>
        private void IsPalindrome(string s, int leftIndex, int rightIndex, ref string result)
        {
            while (leftIndex >= 0 && rightIndex < s.Length && s[leftIndex] == s[rightIndex])
            {
                --leftIndex;
                ++rightIndex;
            }

            if (leftIndex < 0 || rightIndex == s.Length || s[leftIndex] != s[rightIndex])
            {
                ++leftIndex;
                --rightIndex;
            }

            var length = leftIndex == rightIndex ? 1 : rightIndex - leftIndex + 1;

            if (length > result.Length)
            {
                ////  Of course, we can return the substring for each case, but it's not very optimal as we have to create the substring even if it's not longer than the current. So, a small optimization.
                result = s.Substring(leftIndex, length);
            }
        }
    }
}
