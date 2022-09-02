namespace LeetCodeNet.Easy.BitManipulation
{
    /// <summary>
    /// https://leetcode.com/problems/power-of-two/
    /// </summary>
    /// <remarks>
    /// Given an integer n, return true if it is a power of two. Otherwise, return false.
    /// An integer n is a power of two, if there exists an integer x such that n == 2x.
    /// Basics of bit manipulations: https://www.hackerearth.com/practice/basic-programming/bit-manipulation/basics-of-bit-manipulation/tutorial/
    /// </remarks>
    public sealed class PowerofTwo_231
    {
        /// <summary>
        /// Direct solution with math
        /// </summary>
        /// <param name="n"> Number </param>
        /// <returns> Flag if power of 2 </returns>
        /// <remarks>
        /// Time complexity: O(log n)
        /// Space complexity: O(1)
        /// </remarks>
        public bool IsPowerOfTwoMath(int n)
        {
            if (n == 0)
            {
                return false;
            }

            //// Check if n can be divided by 2. Do it repeatedly/
            while (n % 2 == 0)
            {
                n /= 2;
            }

            return n == 1;
        }

        /// <summary>
        /// Bit solution
        /// </summary>
        /// <param name="n"> Number </param>
        /// <returns> Flag if power of 2 </returns>
        /// <remarks>
        /// Time complexity: O(1)
        /// Space complexity: O(1)
        /// </remarks>
        public bool IsPowerOfTwoBit(int n)
        {
            //// N is power of 2 ONLY if it has only one setted bit in bit representation, like:
            /// 1, 10, 100, 1000, 10000
            /// Think about what is n-1:
            /// 10 - 1 = 1
            /// 100 -1 = 010
            /// 1000 -1 = 0100
            /// So n & n-1 should be a zero, if we have a number which can be divided by 2.
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}