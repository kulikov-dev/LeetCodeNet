namespace LeetCodeNet.Easy.BitManipulation
{
    /// <summary>
    /// https://leetcode.com/problems/hamming-distance/
    /// </summary>
    /// <remarks> The Hamming distance between two integers is the number of positions at which the corresponding bits are different.
    /// Given two integers x and y, return the Hamming distance between them.
    /// Detailed explanation of bits operators is here: https://docs.microsoft.com/en-gb/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators
    /// </remarks>
    internal sealed class HammingDistance_461
    {
        /// <summary>
        /// The best way to do it is to use bit manipulations to get every symbol of a number in a binary representation
        /// </summary>
        /// <param name="x"> Number 1 </param>
        /// <param name="y"> Number 2 </param>
        /// <returns> Hamming distance </returns>
        /// <remarks>
        /// Time complexity: O(1)
        /// Space complexity: O(1)
        /// </remarks>
        public int HammingDistance(int x, int y)
        {
            var hammingDistance = 0;

            //// During the process we shifting bits, until they become zero
            while (x != 0 || y != 0)
            {
                //// The trickiest part is to detect every bit of a number. For this we use AND operation with 1.
                /// Let's assume that we have 11010 number. So, step by step for number 1:
                /// 1. 1101[0] & 1 = 0, as we do 0 AND 1 = 0
                /// 2. We shift number to the right, so we have 1101
                /// 3. 110[1] & 1 = 1
                /// 4. Shift and get 110;
                /// 5. etc..
                /// The idea is to do this procedure for both numbers and compare results.
                /// If one number has 1 and the second one not - it's our goal.
                if ((x & 1) != (y & 1))
                {
                    ++hammingDistance;
                }

                //// Use right shift operator to move bits
                x >>= 1;
                y >>= 1;
            }

            return hammingDistance;
        }
    }
}