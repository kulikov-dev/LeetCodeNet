using System.Text;

namespace LeetCodeNet.Easy.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/backspace-string-compare
    /// </summary>
    /// <remarks>
    /// Given two strings s and t, return true if they are equal when both are typed into empty text editors. '#' means a backspace character.
    /// Note that after backspacing an empty text, the text will continue empty.
    /// </remarks>
    internal sealed class BackspaceStringCompare_844
    {
        /// <summary>
        /// Use stack to put all elements in two stacks
        /// If we meet '#' char, than Pop element from the stack.
        /// Than need to check if two stacks are equal
        /// </summary>
        /// <param name="s"> String S </param>
        /// <param name="t"> String T </param>
        /// <returns> True, if equal </returns>
        /// <remarks>
        /// Time complexity: O(n_m)
        /// Space complexity: O(n+m)
        /// </remarks>
        public bool BackspaceCompareStack(string s, string t)
        {
            var stackS = FillStack(s);
            var stackT = FillStack(t);

            while (stackS.Count > 0 && stackT.Count > 0)
            {
                if (stackS.Pop() != stackT.Pop())
                {
                    return false;
                }
            }

            return stackT.Count == 0 && stackS.Count == 0;
        }

        /// <summary>
        /// Support void to convert string to queue
        /// </summary>
        /// <param name="str"> Input string </param>
        /// <returns> Queue </returns>
        private Stack<char> FillStack(string str)
        {
            var result = new Stack<char>();

            for (var i = 0; i < str.Length; i++)
            {
                if (str[i] == '#')
                {
                    if (result.Count > 0)
                    {
                        result.Pop();
                    }
                }
                else
                {
                    result.Push(str[i]);
                }
            }

            return result;
        }

        /// <summary>
        /// Approach to convert string to the resulted string without backspaces.
        /// Use two-pointers approach where the second pointer shows to the last correct position
        /// </summary>
        /// <param name="s"> String S </param>
        /// <param name="t"> String T </param>
        /// <returns> True, if equal </returns>
        /// <remarks>
        /// Time complexity: O(n_m)
        /// Space complexity: O(n+m)
        /// </remarks>
        public bool BackspaceCompareStringBuilder(string s, string t)
        {
            return RecreateString(s).Equals(RecreateString(t));
        }

        /// <summary>
        /// Convert string to resulted string without backspaces
        /// </summary>
        /// <param name="str"> Input string </param>
        /// <returns> Resulted string </returns>
        private string RecreateString(string str)
        {
            var result = new StringBuilder(str.Length);
            var backSpaceCounters = 0;

            for (var i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == '#')
                {
                    ++backSpaceCounters;
                }
                else if (backSpaceCounters > 0)
                {
                    --backSpaceCounters;
                }
                else
                {
                    result.Append(str[i]);
                }
            }

            return result.ToString();
        }
    }
}
