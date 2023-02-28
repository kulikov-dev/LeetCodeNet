using System.Text;

namespace LeetCodeNet.Medium.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/letter-case-permutation/
    /// </summary>
    /// <remarks>
    /// Given a string s, you can transform every letter individually to be lowercase or uppercase to create another string.
    /// Return a list of all possible strings we could create.Return the output in any order.
    /// </remarks>
    public sealed class LetterCasePermutation_784
    {
        /// <summary>
        /// When we speak about permutations - the common solution here is to use recursive for the backtracking
        ///          a1b2         i = 0, char = a. We have two variants here
        ///       /        \
        ///     a1b2       A1b2   i = 1. It's a number, no changes
        ///     |           |
        ///    a1b2        A1b2   i = 2, char = b. Another two variants, but for the previous two variants. Total we have 4 variants here
        ///    /  \        / \
        ///  a1b2 a1B2  A1b2 A1B2 i = 3, char = 2. No changes again
        ///   |    |     |     |
        ///  a1b2 a1B2  A1b2 A1B2 i = 4 = S.length(). Finish recursion, answer.
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <returns> List of permutations </returns>
        /// <remarks>
        /// Time complexity: O(2^n)
        /// Space complexity: O(2^n)
        /// </remarks>
        public IList<string> LetterCasePermutation(string s)
        {
            var result = new List<string>
            {
                s
            };

            Recursive(s, 0, ref result);

            return result;
        }

        /// <summary>
        /// Recursion method
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <param name="index"> Current char index </param>
        /// <param name="result"> List of permutations </param>
        private void Recursive(string s, int index, ref List<string> result)
        {
            if (index == s.Length)
            {
                return;
            }

            for (var i = 0; i < s.Length; ++i)
            {
                if (!char.IsLetter(s[i]))           // We don't need to go further for the numbers
                {
                    continue;
                }

                var sb = new StringBuilder(s);
                sb[i] = char.IsUpper(sb[i]) ? char.ToLower(sb[i]) : char.ToUpper(sb[i]);

                result.Add(sb.ToString());
                Recursive(sb.ToString(), i + 1, ref result);
            }
        }
    }
}
