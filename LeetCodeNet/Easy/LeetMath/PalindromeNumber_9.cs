namespace LeetCodeNet.Easy.LeetMath
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-number/description/
    /// </summary>
    /// <remarks> Given an integer x, return true if x is a palindrome, and false otherwise.</remarks>
    public sealed class PalindromeNumber_9
    {
        /// <summary>
        /// The idea is to reverse the initial number and just compare original with reversed
        /// For reverse we will use the standard operations: /, %
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            var tempX = x;
            var reversedX = 0;

            while (tempX != 0)
            {
                reversedX = reversedX * 10 + tempX % 10;

                tempX /= 10;
            }

            return reversedX == x;
        }
    }
}
