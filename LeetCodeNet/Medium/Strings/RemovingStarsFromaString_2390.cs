using System.Text;

namespace LeetCodeNet.Medium.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/removing-stars-from-a-string
    /// </summary>
    /// <remarks>
    /// You are given a string s, which contains stars *.
    /// In one operation, you can:
    /// Choose a star in s.
    /// Remove the closest non-star character to its left, as well as remove the star itself.
    /// Return the string after all stars have been removed.
    /// </remarks>
    internal sealed class RemovingStarsFromaString_2390
    {
        /// <summary>
        /// Two pointers approach is suitable here. StringBuilder allows us to work with the string like with a char array
        /// First pointer for the current char, the second one - is for tracking last valid position:
        /// For example: ab**
        /// Step 1: char: 'a', first pointer: 0, secondPointer: 0;
        /// Step 2: char: 'b', first pointer: 1, secondPointer: 1;
        /// Step 3: char '*', first pointer: 2, second pointer: 1;
        /// Step 3: char '*', first pointer: 3, second pointer: 0
        /// For the result we take string from 0 to the second pointer.
        /// In our case it is: zero sized string
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <returns> Modified string </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public string RemoveStars(string s)
        {
            var sb = new StringBuilder(s);
            var lastValidIndex = 0;

            for (var i = 0; i < s.Length; ++i)
            {
                if (s[i] == '*')
                {
                    --lastValidIndex;
                }
                else
                {
                    sb[lastValidIndex] = s[i];

                    ++lastValidIndex;
                }
            }

            return sb.ToString()[..lastValidIndex];     // syntax sugar of: .Substring(0, lastValidIndex);
        }
    }
}
