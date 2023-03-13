namespace LeetCodeNet.Medium.LeetMath
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-integer/
    /// </summary>
    /// <remarks>
    /// Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
    /// Assume the environment does not allow you to store 64-bit integers(signed or unsigned).
    /// </remarks>
    public sealed class ReverseInteger_7
    {
        /// <summary>
        /// 321. 321 % 10 = 1. 1 * 10 = 10. 32 % 10 = 2. 10 + 2 = 12 ,etc
        /// To meet the condition about integer the easiest way is to store information in long
        /// </summary>
        /// <param name="x"> Input int </param>
        /// <returns> Reversed int </returns>
        /// <remarks>
        /// Time complexity: O(n^2)
        /// Space complexity: O(n)
        /// </remarks>
        public int ReverseSimple(int x)
        {
            var result = 0l;

            while (x != 0)
            {
                result = result * 10 + x % 10;

                x /= 10;
            }

            return result is < int.MinValue or > int.MaxValue - 1 ? 0 : (int)result;
        }

        /// <summary>
        /// As we can't store the long values, we should assume that sum > than int.MaxValue will give us overflow and random number
        /// So, we need to check if previous value and current value - sum are equal.
        /// </summary>
        /// <param name="x"> Input int </param>
        /// <returns> Reversed int </returns>
        /// <remarks>
        /// Time complexity: O(n^2)
        /// Space complexity: O(n)
        /// </remarks>
        public int ReverseWithoutLong(int x)
        {
            var result = 0;
            var prevValue = 0;

            while (x != 0)
            {
                result = result * 10 + x % 10;

                if (prevValue != result / 10)
                {
                    return 0;
                }

                x /= 10;

                prevValue = result;
            }

            return result;
        }
    }
}
