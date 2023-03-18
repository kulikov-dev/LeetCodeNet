namespace LeetCodeNet.Easy.BitManipulation
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-bits/
    /// </summary>
    /// <remarks> Reverse bits of a given 32 bits unsigned integer. </remarks>
    internal sealed class ReverseBits_190
    {
        /// <summary>
        /// Bit solution
        /// </summary>
        /// <param name="n"> Number </param>
        /// <returns> Reversed number </returns>
        /// <remarks>
        /// Time complexity: O(1)
        /// Space complexity: O(1)
        /// </remarks>
        public uint reverseBits(uint n)
        {
            uint result = 0;

            // We have 32 bit number, so to not to miss spaces - we will iterate through all digits
            for (var i = 0; i < 32; ++i)
            {
                result <<= 1;
                result |= (n & 1);
                n >>= 1;
            }

            return result;
        }
    }
}
