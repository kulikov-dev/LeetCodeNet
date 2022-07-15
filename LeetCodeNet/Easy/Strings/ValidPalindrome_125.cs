namespace LeetCodeNet.Easy.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/valid-palindrome/
    /// </summary>
    /// <remarks> More information about approach is here: https://leetcode.com/articles/two-pointer-technique/ </remarks>
    public class ValidPalindrome_125
    {
        /// <summary>
        /// Given a string s, return true if it is a palindrome, or false otherwise.
        /// </summary>
        /// <param name="s"> String </param>
        /// <returns> Flag if palindrome </returns>
        public bool IsPalindromeLinq(string s)
        {
            //// Use LINQ approach to remove all not valid chars and reverse string. Then just compare initial and reversed strings 
            var validString = new string(s.Where(x => char.IsLetterOrDigit(x)).ToArray());
            var reversedString = new string(validString.Reverse().ToArray());
            //// We use OrdinalIgnoreCase, because 'A' and 'a' are equals. According to Richter it's more prefferable than CurrentCultureIgnoreCase.
            return validString.Equals(reversedString, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Given a string s, return true if it is a palindrome, or false otherwise.
        /// </summary>
        /// <param name="s"> String </param>
        /// <returns> Flag if palindrome </returns>
        public bool IsPalindromePointers(string s)
        {
            //// Use two-pointers approach to check each char step by step from left and right side.
            //// So one pointer starts from the beginning while the other pointer starts from the end.
            var leftIndex = 0;
            var rightIndex = s.Length - 1;
            //// Instead of StringComparison we can just use ToUpper to put all chars in the same case.
            s = s.ToUpper();
            while (leftIndex < rightIndex)
            {
                //// We go right for the left pointer, skipping all not valid chars like ':', ' ', etc
                while (leftIndex < s.Length && !char.IsLetterOrDigit(s[leftIndex]))
                {
                    ++leftIndex;
                }

                //// And do the same for the right pointer, but on the other side
                while (rightIndex > -1 && !char.IsLetterOrDigit(s[rightIndex]))
                {
                    --rightIndex;
                }

                if (leftIndex < rightIndex && s[leftIndex] != s[rightIndex])
                {
                    return false;
                }

                ++leftIndex;
                --rightIndex;
            }

            return true;
        }
    }
}