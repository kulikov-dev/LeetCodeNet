namespace LeetCodeNet.Easy.LeetMath
{
    /// <summary>
    /// https://leetcode.com/problems/sign-of-the-product-of-an-array/
    /// </summary>
    /// <remarks> 
    /// There is a function signFunc(x) that returns:
    /// 1 if x is positive.
    /// -1 if x is negative.
    /// 0 if x is equal to 0.
    /// You are given an integer array nums.Let product be the product of all values in the array nums.
    /// Return signFunc(product).
    /// </remarks>
    public sealed class SignoftheProductofanArray_1822
    {
        /// <summary>
        /// The total production will negative, if we have odd amount of negative values. Because if the even, than -1*-1 = 1.
        /// So, we just need to calc amount of negative values and find is it odd or even.
        /// </summary>
        /// <param name="nums"> Array </param>
        /// <returns>- 1 if -, 1 if + </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public int ArraySign(int[] nums)
        {
            var negativesCount = 0;

            foreach (var num in nums)
            {
                //// We have to stop counting, if we have at least one zero in the input array. 
                if (num == 0)
                {
                    return 0;
                }

                negativesCount += num < 0 ? 1 : 0;
            }

            return negativesCount % 2 == 0 ? 1 : -1;

        }
    }
}
