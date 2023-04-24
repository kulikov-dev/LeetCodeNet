namespace LeetCodeNet.Easy.LeetMath
{
    /// <summary>
    /// Given a non-negative integer x, return the square root of x rounded down to the nearest integer. The returned integer should be non-negative as well.
    /// You must not use any built-in exponent function or operator.
    /// </summary>
    internal sealed class SqrtX_69
    {
        /// <summary>
        /// The same approach of binary search with small modifications like in <see cref="ValidPerfectSquare_367"/>
        /// </summary>
        /// <param name="x"> Input in int </param>
        /// <returns> Square </returns>
        public int MySqrt(int x)
        {
            if (x == 0)
            {
                return 0;
            }

            long leftIndex = 1;
            long rightIndex = x - 1;

            while (leftIndex <= rightIndex)
            {
                var middleIndex = leftIndex + (rightIndex - leftIndex) / 2;

                if (middleIndex * middleIndex <= x && (middleIndex + 1) * (middleIndex + 1) > x)
                {
                    return (int)middleIndex;
                }

                if (middleIndex * middleIndex < x)
                {
                    leftIndex = middleIndex + 1;
                }
                else
                {
                    rightIndex = middleIndex;
                }
            }

            return (int)leftIndex;
        }
    }
}
