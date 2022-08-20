namespace LeetCodeNet.Easy.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/replace-all-digits-with-characters/
    /// </summary>
    /// <remarks>
    /// You are given a 0-indexed string s that has lowercase English letters in its even indices and digits in its odd indices.
    /// There is a function shift(c, x), where c is a character and x is a digit, that returns the xth character after c.
    /// For every odd index i, you want to replace the digit s[i] with shift(s[i-1], s[i]).
    /// Return s after replacing all digits.
    /// </remarks>
    public sealed class ReplaceAllDigitswithCharacters_1844
    {
        /// <summary>
        /// The key is that new character = previous character + current number. Then - char manipulations.
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <returns> Shifted string </returns>
        /// <remarks>
        /// It is guaranteed that shift(s[i - 1], s[i]) will never exceed 'z'.
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public string ReplaceDigitsWithOriginal(string s)
        {
            //// Create new array, as it's easier to manipulate with it. We also can use StringBuilder here.
            var result = s.ToCharArray();

            //// We need to process only numbers, so we take only odd items.
            for (var i = 1; i < s.Length; i += 2)
            {
                //// Char manipulation on ASCII codes. So, 0 has 48 code, 2 has 50 ASCII code. That's why we need to substract them to get the real number
                /// It's easier to understand if open an ASCII codes table
                var offset = s[i] - '0';

                //// Char manipulation again. So, 'a' has code 97, if we need to offset it by 1, we can do addition and get code 98 which is 'b'.
                result[i] = (char)(s[i - 1] + offset);
            }

            return new string(result);
        }

        /// <summary>
        /// Follow-up question if shift can exceed 'z'. The same approach, but need to think what to do if shifting is exceed 'z' char.
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <returns> Shifted string </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public string ReplaceDigitsWithExceed(string s)
        {
            const int alphabetsLength = 26;
            var result = s.ToCharArray();
            for (var i = 1; i < s.Length; i += 2)
            {
                var offset = s[i] - '0';

                //// To prevent exceeding we need to get the real position in English alphabet.
                /// So, we substract 'a' to get it. Than we use % to prevent exceeding, so if 
                /// we get 27 - after the operation we get 2. 
                /// We do +'a' to return back to ASCII code.
                result[i] = (char)((s[i-1] - 'a' + offset) % alphabetsLength + 'a');
            }

            return new string(result);
        }
    }
}