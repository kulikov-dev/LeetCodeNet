namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/plus-one/
    /// </summary>
    /// <remarks>
    /// You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer.
    /// The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.
    /// Increment the large integer by one and return the resulting array of digits.
    /// </remarks>
    internal sealed class PlusOne_66
    {
        /// <summary>
        /// The idea is to reproduce adding step by step like we do it in a real life. Start from last digit and go forward if necessary
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n), as we don't change source array
        /// </remarks>
        public int[] PlusOne(int[] digits)
        {
            var result = (int[])digits.Clone();

            for (var i = digits.Length - 1; i >= 0; --i)
            {
                var currentSum = digits[i] + 1;

                if (currentSum < 10)
                {
                    //// The most situations like: 123 -> 124, 129 -> 130
                    result[i] = currentSum;

                    return result;
                }

                result[i] = 0;
            }

            //// For the case, when the input array consits of 9's: 99 -> 100, 999 -> 1000
            result = new int[digits.Length + 1];
            result[0] = 1;

            return result;
        }
    }
}
