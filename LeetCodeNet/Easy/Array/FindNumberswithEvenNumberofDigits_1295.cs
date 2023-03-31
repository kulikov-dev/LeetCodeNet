namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/find-numbers-with-even-number-of-digits/
    /// </summary>
    /// <remarks> Given an array nums of integers, return how many of them contain an even number of digits. </remarks>
    internal sealed class FindNumberswithEvenNumberofDigits_1295
    {
        /// <summary>
        /// The trick here is to understand how to count the digits. The easiest way is simple divide the number to 10 until it will become 0, like:
        /// Input: 512;
        /// Step1: 512 / 10 = 51, result = 1
        /// Step2: 51 / 10 = 5, result = 2
        /// Step3: 5 / 10 = 0, result 3
        /// Than, we just check if it is even using '%' operator.
        /// </summary>
        /// <param name="nums"> Input array </param>
        /// <returns> Numbers count with even number of digits </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(1)
        /// </remarks>
        public int FindNumbers(int[] nums)
        {
            var total = 0;
            for (var i = 0; i < nums.Length; ++i)
            {
                var digitsCount = CountDigits(nums[i]);

                total += digitsCount % 2 == 0 ? 1 : 0;
            }

            return total;
        }

        /// <summary>
        /// Help function to calc number of digits
        /// </summary>
        /// <param name="num"> Number </param>
        /// <returns> Number of digits in the number </returns>
        private int CountDigits(int num)
        {
            var counter = 0;

            while (num != 0)
            {
                ++counter;
                num /= 10;
            }

            return counter;
        }
    }
}
