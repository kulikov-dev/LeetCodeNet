using System.Text;

namespace LeetCodeNet.Medium.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/decode-string
    /// </summary>
    /// <remarks>
    /// Given an encoded string, return its decoded string.
    /// The encoding rule is: k[encoded_string], where the encoded_string inside the square brackets is being repeated exactly k times.Note that k is guaranteed to be a positive integer.
    /// You may assume that the input string is always valid; there are no extra white spaces, square brackets are well-formed, etc.
    /// Furthermore, you may assume that the original data does not contain any digits and that digits are only for those repeat numbers, k.For example, there will not be input like 3a or 2[4].
    /// </remarks>
    internal sealed class DecodeString_394
    {
        /// <summary>
        /// The idea is to use two stacks: one to store amount of repetition, second for string to repeat.
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <returns> Decoded string </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public string DecodeString(string s)
        {
            var result = new StringBuilder(s.Length * 2);
            var stackCounts = new Stack<int>();
            var stackSources = new Stack<string>();

            var pointer = 0;

            while (pointer < s.Length)
            {
                if (char.IsDigit(s[pointer]))
                {
                    var num = 0;

                    while (char.IsDigit(s[pointer]))
                    {
                        num *= 10;
                        num += s[pointer] - '0';
                        pointer++;
                    }

                    stackCounts.Push(num);
                }
                else if (s[pointer] == '[')
                {
                    stackSources.Push(result.ToString());
                    result.Clear();
                    pointer++;
                }
                else if (s[pointer] == ']')
                {
                    var temp = new StringBuilder(stackSources.Pop());
                    var count = stackCounts.Pop();

                    temp.Append(new StringBuilder(string.Join("", Enumerable.Repeat(result.ToString(), count))));

                    result = new StringBuilder(temp.ToString());

                    pointer++;
                }
                else
                {
                    result.Append(s[pointer]);
                    ++pointer;
                }

            }

            return result.ToString();
        }
    }
}
