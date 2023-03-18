using System.Text;

namespace LeetCodeNet.Easy.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/decrypt-string-from-alphabet-to-integer-mapping/
    /// </summary>
    /// <remarks>
    /// You are given a string s formed by digits and '#'. We want to map s to English lowercase characters as follows:
    /// Characters('a' to 'i') are represented by('1' to '9') respectively.
    /// Characters('j' to 'z') are represented by('10#' to '26#') respectively.
    /// Return the string formed after mapping.
    /// The test cases are generated so that a unique mapping will always exist.
    /// </remarks>
    internal sealed class DecryptStringfromAlphabettoIntegerMapping_1309
    {
        /// <summary>
        /// Each letter in this alphabet is number of letter in the alphabet/offset. 
        /// So, we can go traversal and add offset to 'a' letter
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string FreqAlphabets(string s)
        {
            var result = new StringBuilder(s.Length);

            for (var i = 0; i <s.Length; i++)
            {
                int charInt;

                if (i < s.Length -2 && s[i+2] == '#')
                {
                    charInt = int.Parse(s.Substring(i, 2)) - 1;

                    i += 2;
                }
                else
                {
                    charInt = s[i] - '0' - 1;
                }

                //// Char manipulation with ASCII codes
                result.Append((char)('a' + charInt));
            }

            return result.ToString();
        }
    }
}