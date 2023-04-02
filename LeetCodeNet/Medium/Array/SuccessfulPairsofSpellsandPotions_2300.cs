namespace LeetCodeNet.Medium.Array
{
    /// <summary>
    /// https://leetcode.com/problems/successful-pairs-of-spells-and-potions/
    /// </summary>
    /// <remarks>
    /// You are given two positive integer arrays spells and potions, of length n and m respectively, where spells[i] represents the strength of the ith spell and potions[j] represents the strength of the jth potion.
    /// You are also given an integer success.A spell and potion pair is considered successful if the product of their strengths is at least success.
    /// Return an integer array pairs of length n where pairs[i] is the number of potions that will form a successful pair with the ith spell.
    /// </remarks>
    internal sealed class SuccessfulPairsofSpellsandPotions_2300
    {
        /// <summary>
        /// The trick here is to understand, when to stop. If we iterate through sorted potions array, the first value which provide us >= success value is the reason to stop, because it's enough to calc:
        /// Length - n pointer is the amount of success spells.
        /// </summary>
        /// <param name="spells"> Spells </param>
        /// <param name="potions"> Potions </param>
        /// <param name="success"> Success number </param>
        /// <returns> Numbers of success casts </returns>
        /// <remarks>
        /// Time complexity: O(n * log(n))
        /// Space complexity: O(1)
        /// </remarks>
        public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
        {
            potions = potions.OrderBy(x => x).ToArray();
            var result = new int[spells.Length];

            for (var i = 0; i < spells.Length; ++i)
            {
                var leftIndexer = 0;
                var rightIndexer = potions.Length - 1;

                while (leftIndexer <= rightIndexer)
                {
                    var middle = leftIndexer + (rightIndexer - leftIndexer) / 2;
                    var product = (long) spells[i] * potions[middle];

                    if (product < success)
                    {
                        leftIndexer = middle + 1;
                    }
                    else
                    {
                        rightIndexer = middle -1;
                    }
                }

                result[i] = potions.Length - leftIndexer;
            }

            return result;
        }
    }
}
