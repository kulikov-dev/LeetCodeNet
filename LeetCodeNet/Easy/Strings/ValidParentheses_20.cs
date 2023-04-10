namespace LeetCodeNet.Easy.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/valid-parentheses/
    /// </summary>
    /// <remarks>
    /// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
    /// An input string is valid if:
    /// Open brackets must be closed by the same type of brackets.
    /// Open brackets must be closed in the correct order.
    /// Every close bracket has a corresponding open bracket of the same type.
    /// </remarks>
    internal sealed class ValidParentheses_20
    {
        /// <summary>
        /// As we need to check correct order, it's suitable to use stack for it.
        /// When we encounter left parentheses - we push the right parentheses into the stack.
        /// If a right parentheses appear in the string - we need to check if stack isn't empty and the otp element is the same.
        /// Otherwise, the string is invalid.
        /// Finally, we must determine whether or not the stack is empty. For cases, like ')' or '()}'
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <returns> True, if valid </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public bool IsValidSimple(string s)
        {
            var stack = new Stack<char>();

            foreach (var ch in s)
            {
                if (ch == '(')
                {
                    stack.Push(')');
                }
                else if (ch == '[')
                {
                    stack.Push(']');
                }
                else if (ch == '{')
                {
                    stack.Push('}');
                }
                else if (stack.Count == 0 || stack.Pop() != ch)
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }

        /// <summary>
        /// Follow-up if we need to check the string with any character.
        /// The same approach, but we use HashMap to check if input char is parentheses
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <returns> True, if valid </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public bool IsValidAnyCharacters(string s)
        {
            var mathcDict = new Dictionary<char, char>()
            {
                {')', '('},
                {'}', '{'},
                {']', '['}
            };

            var stack = new Stack<char>();

            foreach (var ch in s)
            {
                if (mathcDict.ContainsValue(ch))
                {
                    stack.Push(ch);
                }
                else if (mathcDict.ContainsKey(ch) && (stack.Count == 0 || mathcDict[ch] != stack.Pop()))
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
