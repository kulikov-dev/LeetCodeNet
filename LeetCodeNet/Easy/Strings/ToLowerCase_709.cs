using System.Text;

namespace LeetCodeNet.Easy.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/to-lower-case/
    /// </summary>
    /// <remarks> Given a string s, return the string after replacing every uppercase letter with the same lowercase letter. </remarks>
    internal sealed class ToLowerCase_709
    {
        /// <summary>
        /// The simpliest solution. Of course in the real interview it's not acceptable
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <returns> String in lower case </returns>
        public string ToLowerCaseSimple(string s)
        {
            return s.ToLower();
        }

        /// <summary>
        /// Idea is to do char manupulations.
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <returns> String in lower case </returns>
        /// <remarks> For better understanding open ASCII table. </remarks>
        public string ToLowerCaseChar(string s)
        {
            //// Use StringBuilder due to immutable nature of string. It's great way to show interviewers your level of knowledge.
            var sb = new StringBuilder(s);
            //// We need to check each char if it's in Upper Range, for better reability we use char's instead of int
            var upperRange = new int[] { 'A', 'Z' };

            for (var i = 0; i < sb.Length; i++)
            {
                if (sb[i] >= upperRange[0] && sb[i] <= upperRange[1])
                {
                    //// Find the position of char in alphabet (for example :
                    /// 'A' has int representation as 65 in ASCII table, 'M' = 77. Diff = 12
                    /// Then we need to offset it to 'a'-'z' offset in ASCII table, so 12 + 'a'(97) and get the new position of char in lower case
                    sb[i] = (char)(sb[i] - 'A' + 'a');
                }
            }

            return sb.ToString();
        }
    }
}