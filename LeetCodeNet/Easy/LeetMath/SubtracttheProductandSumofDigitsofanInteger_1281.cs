namespace LeetCodeNet.Easy.LeetMath
{
    /// <summary>
    /// https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/
    /// </summary>
    /// Given an integer number n, return the difference between the product of its digits and the sum of its digits.
    public sealed class SubtracttheProductandSumofDigitsofanInteger_1281
    {
        /// <summary>
        /// Keep in mind the '%' operator which return a modulo. This is enough to solve the task
        /// </summary>
        /// <param name="n"> Source number </param>
        /// <returns> Diff between product and sum of source digits </returns>
        /// <remarks>
        /// Time complexity: O(1)
        /// Space complexity: O(1)
        /// </remarks>
        public int SubtractProductAndSum(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            var prod = 1;
            var sum = 0;
            while (n != 0)
            {
                var temp = n % 10;
                prod *= temp;
                sum += temp;
                n /= 10;
            }

            return prod - sum;
        }
    }
}
