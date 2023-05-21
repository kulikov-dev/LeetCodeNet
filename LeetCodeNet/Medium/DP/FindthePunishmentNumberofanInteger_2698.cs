namespace LeetCodeNet.Medium.DP
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-punishment-number-of-an-integer
    /// </summary>
    /// <remarks>
    /// Given a positive integer n, return the punishment number of n.
    /// The punishment number of n is defined as the sum of the squares of all integers i such that:
    /// 1 <= i <= n
    /// The decimal representation of i * i can be partitioned into contiguous substrings such that the sum of the integer values of these substrings equals i.
    /// </remarks>
    internal sealed class FindthePunishmentNumberofanInteger_2698
    {
        /// <summary>
        /// The first idea that came to mind was backtracking.
        /// We have a set of numbers from 1 to n, and for each number we need to check for condition.
        /// Let's check number 1296. It can contain: 1+2+9+6 or 12+9+6 or 129+6 or 12+96, etc.
        /// So, it's kind of a task of finding all combinations and checking them for condition. The approach is standard for this: use recursion and array to store all combinations
        /// </summary>
        /// <param name="n"> Input n </param>
        /// <returns> The punishment number of n </returns>
        /// <remarks>
        /// Time complexity: 
        /// Space complexity: 
        /// </remarks>
        public int PunishmentNumber(int n)
        {
            var result = 0;

            for (var i = 0; i <= n; i++)
            {
                var squared = i * i;

                if (IsSubPunishment(squared.ToString(), i, 0, new List<int>()))
                {
                    result += squared;
                }
            }

            return result;
        }

        /// <summary>
        /// Recursive func to find if number is satisfy condition to be included to the punishment number
        /// </summary>
        /// <param name="squaredNumStr"> Squared number </param>
        /// <param name="num"> Number </param>
        /// <param name="currentCharIndex"> Index of a current number </param>
        /// <param name="subNumbers"> Current array of sub-numbers </param>
        /// <returns> True if number satisfy condition </returns>
        public bool IsSubPunishment(string squaredNumStr, int num, int currentCharIndex, List<int> subNumbers)
        {
            if (currentCharIndex == squaredNumStr.Length)
            {
                return subNumbers.Sum() == num;
            }

            var currentNum = squaredNumStr[currentCharIndex] - '0';

            subNumbers.Add(currentNum);

            var result = IsSubPunishment(squaredNumStr, num, currentCharIndex + 1, subNumbers);

            if (result)
            {
                return true;
            }

            subNumbers.RemoveAt(subNumbers.Count - 1);

            if (currentCharIndex > 0)
            {
                subNumbers[subNumbers.Count - 1] = int.Parse(subNumbers[subNumbers.Count - 1].ToString() + currentNum);

                return IsSubPunishment(squaredNumStr, num, currentCharIndex + 1, subNumbers);
            }

            return false;
        }
    }
}
