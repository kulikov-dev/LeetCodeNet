namespace LeetCodeNet.Medium.LeetMath
{
    /// <summary>
    /// https://leetcode.com/problems/sum-of-square-numbers
    /// </summary>
    /// <remarks> Given a non-negative integer c, decide whether there're two integers a and b such that a2 + b2 = c. </remarks>
    internal sealed class SumofSquareNumbers_633
    {
        /// <summary>
        /// Use two pointers approach to find both a and b values.
        /// </summary>
        /// <param name="c"> Desired value </param>
        /// <returns> True, if there're two integers such a2+b2=c </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public bool JudgeSquareSumPointers(int c)
        {
            long leftIndexer = 0;
            var rightIndexer = (long)Math.Sqrt(c);

            while (leftIndexer <= rightIndexer)
            {
                var square1 = leftIndexer * leftIndexer;
                var square2 = rightIndexer * rightIndexer;

                var value = square1 + square2;

                if (value == c)
                {
                    return true;
                }

                if (value > c)
                {
                    --rightIndexer;
                }
                else
                {
                    ++leftIndexer;
                }
            }

            return false;
        }

        /// <summary>
        /// Use hashset to calc all sqr values. 
        /// </summary>
        /// <param name="c"> Desired value </param>
        /// <returns> True, if there're two integers such a2+b2=c </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public bool JudgeSquareSumHash(int c)
        {
            var hashSet = new HashSet<long>();

            for (var i = 0; i <= Math.Sqrt(c); ++i)
            {
                hashSet.Add(i * i);
                if (hashSet.Contains(c - i * i))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
