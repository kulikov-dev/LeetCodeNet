namespace LeetCodeNet.Easy.BitManipulation
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-1-bits/
    /// </summary>
    /// <remarks> Write a function that takes an unsigned integer and returns the number of '1' bits it has (also known as the Hamming weight).
    /// Detailed explanation of bits operators is here: https://docs.microsoft.com/en-gb/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators
    /// </remarks>
    public sealed class Numberof1Bits_191
    {
        /// <summary>
        /// Get every last bit and sum it to a result value
        /// </summary>
        /// <param name="n"> Number </param>
        /// <returns> Count of 1 </returns>
        /// <remarks>
        /// Time complexity: O(log n)
        /// Space complexity: O(1)
        /// </remarks>
        public int HammingWeightShift(uint n)
        {
            uint result = 0;
            while (n > 0)
            {
                //// The trickiest part is to detect every bit of a number. For this we use AND operation with 1.
                /// Let's assume that we have 11010 number. So, step by step for number 1:
                /// 1. 1101[0] & 1 = 0, as we do 0 AND 1 = 0
                /// 2. We shift number to the right, so we have 1101
                /// 3. 110[1] & 1 = 1
                /// 4. Shift and get 110;
                /// 5. etc..
                result += n & 1;
                n >>= 1;
            }

            return (int)result;
        }

        /// <summary>
        /// More elegant solution as number of iterations will equal to number of 1
        /// </summary>
        /// <param name="n"> Number </param>
        /// <returns> Count of 1 </returns>
        /// <remarks>
        /// Time complexity: O(log n)
        /// Space complexity: O(1)
        /// </remarks>
        public int HammingWeightBit(uint n)
        {
            var result = 0;
            while (n > 0)
            {
                ++result;

                //// Change the first 1 from right to the 0
                /// 1. n = 1010
                /// 2. n-1 = 1001
                /// n & n-1 = 1000 (!)
                /// So we traverse only through 1 bits
                n &= (n - 1);
            }

            return result;
        }
    }
}