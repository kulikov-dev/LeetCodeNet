namespace LeetCodeNet.Easy.LeetMath
{
    /// <summary>
    /// https://leetcode.com/problems/valid-perfect-square
    /// </summary>
    /// <remarks>
    /// Given a positive integer num, return true if num is a perfect square or false otherwise.
    /// A perfect square is an integer that is the square of an integer.In other words, it is the product of some integer with itself.
    /// You must not use any built-in library function, such as sqrt.
    /// </remarks>
    internal sealed class ValidPerfectSquare_367
    {
        /// <summary>
        /// The most efficient way is to use binary search, where our ranges are from 1 to num -1.
        /// The trick here is using 'long' type as in some cases it can gives us overflow with 'int'
        /// </summary>
        /// <param name="num"> Num </param>
        /// <returns> True, if has perfect square </returns>
        /// <remarks>
        /// Time complexity: O(log n)
        /// Space complexity: O(1)
        /// </remarks>
        public bool IsPerfectSquare(int num)
        {
            long leftIndex = 1;
            long rightIndex = num - 1;

            while (leftIndex < rightIndex)
            {
                long middleIndex = leftIndex + (rightIndex - leftIndex) / 2;

                if (middleIndex * middleIndex == num)
                {
                    return true;
                }

                if (middleIndex * middleIndex > num)
                {
                    rightIndex = middleIndex;
                }
                else
                {
                    leftIndex = middleIndex + 1;
                }
            }

            return leftIndex * leftIndex == num;
        }
    }
}
