namespace LeetCodeNet.Easy.BitManipulation
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/
    /// </summary>
    /// <remarks>
    /// Given an integer num, return the number of steps to reduce it to zero.
    /// In one step, if the current number is even, you have to divide it by 2, otherwise, you have to subtract 1 from it.
    /// Basics of bit manipulations: https://www.hackerearth.com/practice/basic-programming/bit-manipulation/basics-of-bit-manipulation/tutorial/
    /// </remarks>
    public sealed class NumberofStepstoReduceaNumbertoZero_1342
    {
        /// <summary>
        /// Direct solution with math
        /// </summary>
        /// <param name="num"> Number </param>
        /// <returns> Number of actions to get 0 </returns>
        /// <remarks>
        /// Time complexity: O(log n)
        /// Space complexity: O(1)
        /// </remarks>
        public int NumberOfStepsMath(int num)
        {
            var result = 0;
            while (num > 0)
            {
                //// Check if number is even
                if (num % 2 == 0)
                {
                    //// Do math for each type of a number
                    num /= 2;
                }
                else
                {
                    num -= 1;
                }

                //// Count operations
                ++result;
            }

            return result;
        }

        /// <summary>
        /// Bit manipulation approach
        /// </summary>
        /// <param name="num"> Number </param>
        /// <returns> Number of actions to get 0 </returns>
        /// <remarks>
        /// Time complexity: O(log n)
        /// Space complexity: O(1)
        /// </remarks>
        public int NumberOfStepsBit(int num)
        {
            var result = 0;
            while (num > 0)
            {
                //// Three steps are here:
                /// 1. To check if number is ODD. In bit representation odd numbers has last bit setted to 1. So if number 1000 - it's even, if 1001 - it's odd.
                /// We can check last bit with & operation, for example: 1001 & 1 = 1 and 1000 & 1 = 0
                /// 2. If it's an even number - we divide by zero. In bit representations for divide to 2 we need to do right  shiift, so number 1000 become 0100
                /// 3. If it's an odd number - we need to substract
                num = (num & 1) == 1 ? num - 1 : num >> 1;

                //// Count operations
                ++result;
            }

            return result;
        }

        /// <summary>
        /// Optimized bit method: we need to count 0 and 1 in the number
        /// </summary>
        /// <param name="num"> Number </param>
        /// <returns> Number of actions to get 0 </returns>
        /// <remarks>
        /// Time complexity: O(log n)
        /// Space complexity: O(1)
        /// </remarks>
        public int NumberOfStepsBitOptimized(int num)
        {
            var result = 0;
            while (num > 0)
            {
                //// Three steps are here:
                /// 1. To check if number is ODD. In bit representation odd numbers has last bit setted to 1. So if number 1000 - it's even, if 1001 - it's odd.
                /// We can check last bit with & operation, for example: 1001 & 1 = 1 and 1000 & 1 = 0
                /// 2. If it's an even number - we need to do only 1 operation: divide;
                /// 3. If it's an odd number - we need to do 2 operations: substract and then divide
                result += (num & 1) == 1 ? 2 : 1;
                num >>= 1;
            }

            //// When we processed number 1 we used two operations, so for the last 1 we need only one operation to get a zero.
            return result > 0 ? result - 1 : 0;
        }
    }
}
