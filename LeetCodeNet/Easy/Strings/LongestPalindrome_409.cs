namespace LeetCodeNet.Easy.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/longest-palindrome
    /// </summary>
    /// <remarks>
    /// Given a string s which consists of lowercase or uppercase letters, return the length of the longest palindrome that can be built with those letters.
    /// Letters are case sensitive, for example, "Aa" is not considered a palindrome here.
    /// </remarks>
    internal sealed class LongestPalindrome_409
    {
        /// What is a palindrome? It's a string that contains even amounts of each symbol + 1 symbol (for example: aaBaa)
        /// <summary>
        /// We also can see, that if we have dddba, we can make a palindrome using an even amount of 'ddd', like dbd.
        /// So, we need to calculate all odd and even symbols and sum them: all Evens + all Odd-1 amount
        /// If we have any odd amounts, we need to add one more symbol:
        /// 1. No need to add for: aabb - the palindrome is abba
        /// 2. Need to add for aadbb - the palindrome is abdba
        /// </summary>
        /// <param name="s"> Intput string </param>
        /// <returns> Longest palindrome length </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1), as we have only letters constant dictionary
        /// </remarks>
        public int LongestPalindromeSimple(string s)
        {
            var dict = new Dictionary<char, int>();

            foreach (var ch in s)
            {
                if (!dict.ContainsKey(ch))
                {
                    dict.Add(ch, 0);
                }

                dict[ch]++;
            }

            var result = 0;
            var hasOdd = false;

            foreach (var item in dict)
            {
                if (item.Value % 2 == 0)
                {
                    result += item.Value;
                }
                else
                {
                    result += item.Value - 1;

                    hasOdd = true;
                }
            }

            return result + (hasOdd ? 1 : 0);
        }

        /// <summary>
        /// The optimized solution with 'calculations in place'
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <returns> Longest palindrome length </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public int LongestPalindromeOptimized(string s)
        {
            var dict = new Dictionary<char, int>();
            var oddCount = 0;

            foreach (var ch in s)
            {
                if (!dict.ContainsKey(ch))
                {
                    dict.Add(ch, 0);
                }

                dict[ch]++;

                if (dict[ch] % 2 == 1)
                {
                    ++oddCount;
                }
                else
                {
                    --oddCount;
                }
            }

            return s.Length - oddCount + (oddCount > 0 ? 1 : 0);
        }
    }
}
