namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/richest-customer-wealth/
    /// </summary>
    /// <remarks>
    /// You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank.
    /// Return the wealth that the richest customer has.
    /// A customer's wealth is the amount of money they have in all their bank accounts. The richest customer is the customer that has the maximum wealth.
    /// </remarks>
    internal sealed class RichestCustomerWealth_1672
    {
        /// <summary>
        /// Use loops to find maximum amount of all accounts for each customer. Then maximum wealth among all customers
        /// </summary>
        /// <param name="accounts"> Accounts </param>
        /// <returns> Maximum wealth </returns>
        /// <remarks>
        /// Time complexity: O(n * m), as we need to loop through two arrays
        /// Space complexity: O(1)
        /// </remarks>
        public int MaximumWealthPass(int[][] accounts)
        {
            var maxWealth = 0;

            foreach (var userAccounts in accounts)
            {
                var currentSum = 0;

                foreach (var account in userAccounts)
                {
                    currentSum += account;
                }

                maxWealth = Math.Max(maxWealth, currentSum);
            }

            return maxWealth;
        }

        /// <summary>
        /// Linq approach
        /// </summary>
        /// <param name="accounts"> Accounts </param>
        /// <returns> Maximum wealth </returns>
        /// <remarks>
        /// Time complexity: O(n * m), as we need to loop through two arrays
        /// Space complexity: O(1)
        /// </remarks>
        public int MaximumWealthLinq(int[][] accounts)
        {
            return accounts.Max(x => x.Sum());
        }
    }
}