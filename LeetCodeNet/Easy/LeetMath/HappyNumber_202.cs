namespace LeetCodeNet.Easy.LeetMath
{
    /// <summary>
    /// https://leetcode.com/problems/happy-number/
    /// </summary>
    /// <remarks>
    ///Write an algorithm to determine if a number n is happy.
    /// A happy number is a number defined by the following process:
    /// Starting with any positive integer, replace the number by the sum of the squares of its digits.
    /// Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
    /// Those numbers for which this process ends in 1 are happy.
    /// Return true if n is a happy number, and false if not.
    /// </remarks>
    public sealed class HappyNumber_202
    {
        /// <summary>
        /// The trick here is how to detect when cycle is going to infinite loop. We will use simple hashset and if numbers start to duplicate - it shows us, that we are draw into infinite loop
        /// </summary>
        /// <param name="n"> Number </param>
        /// <returns> Flag if happy </returns>
        /// <remarks>
        /// Time complexity: O(log(n))
        /// Space complexity: O(log(n))
        /// </remarks>
        public bool IsHappy(int n)
        {
            var numbers = new HashSet<int>();
            while (true)
            {
                var newNumber = 0;
                while (n != 0)
                {
                    newNumber += (int)Math.Pow(n % 10, 2);
                    n /= 10;
                }

                n = newNumber;
                if (n == 1)
                {
                    return true;
                }

                if (numbers.Contains(n))
                {
                    return false;
                }

                numbers.Add(n);
            }
        }
    }
}
