using System.Text;

namespace LeetCodeNet.Easy.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/goal-parser-interpretation/
    /// </summary>
    /// <remarks>
    /// You own a Goal Parser that can interpret a string command. The command consists of an alphabet of "G", "()" and/or "(al)" in some order.
    /// The Goal Parser will interpret "G" as the string "G", "()" as the string "o", and "(al)" as the string "al".
    /// The interpreted strings are then concatenated in the original order.
    /// Given the string command, return the Goal Parser's interpretation of command.
    /// </remarks>
    internal sealed class GoalParserInterpretation_1678
    {
        /// <summary>
        /// Just replace commands to desired.
        /// </summary>
        /// <param name="command"> Input string </param>
        /// <returns> Decoded string </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public string InterpretReplace(string command)
        {
            //// Use StringBuilder to optimize work with immutable strings
            var result = new StringBuilder(command);

            return result.Replace("()", "o").Replace("(al)", "al").ToString();
        }

        /// <summary>
        /// Use pointers to detect commands
        /// </summary>
        /// <param name="command"> Input string </param>
        /// <returns> Decoded string </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public string InterpretPointers(string command)
        {
            var result = new StringBuilder(command.Length);

            for (var i = 0; i < command.Length; ++i)
            {
                if (command[i] == '(')
                {
                    if (command[i+1] == ')')
                    {
                        result.Append('o');
                        ++i;
                    }
                    else
                    {
                        result.Append("al");
                        i += 3;
                    }
                }
                else if (command[i] == 'G')
                {
                    result.Append(command[i]);
                }
            }

            return result.ToString();
        }
    }
}