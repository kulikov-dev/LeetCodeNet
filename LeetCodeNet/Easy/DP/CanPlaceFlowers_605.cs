namespace LeetCodeNet.Easy.DP
{
    /// <summary>
    /// https://leetcode.com/problems/can-place-flowers/
    /// </summary>
    /// <remarks>
    /// You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.
    /// Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n, return if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule.
    /// </remarks>
    internal sealed class CanPlaceFlowers_605
    {
        /// <summary>
        /// Like usual in DP tasks, it's better to solve it in a recursion way. <see cref="MinCostClimbingStairs_746"/>
        /// </summary>
        /// <param name="flowerbed"> Flowerbed </param>
        /// <param name="n"> Count of plants to place </param>
        /// <returns> True if possible </returns>
        public bool CanPlaceFlowersRecursive(int[] flowerbed, int n)
        {
            var result = Recursive(flowerbed, 0, 0, n);

            return result >= n;
        }

        /// <summary>
        /// Recursive solution
        /// </summary>
        /// <param name="flowerbed"> Flowerbed </param>
        /// <param name="currentPos"> Current position </param>
        /// <param name="currentPlanted"> Number of current planted plants </param>
        /// <param name="n"> Count of plants to place </param>
        /// <returns> Number of current platned plants </returns>
        private int Recursive(int[] flowerbed, int currentPos, int currentPlanted, int n)
        {
            if (currentPos >= flowerbed.Length)
            {
                return currentPlanted;
            }

            if (currentPlanted == n)
            {
                return currentPlanted;
            }

            if (flowerbed[currentPos] == 1)
            {
                return Recursive(flowerbed, currentPos + 2, currentPlanted, n);
            }

            var isPlant = 0;

            if ((currentPos == 0 || flowerbed[currentPos - 1] == 0) && (currentPos == flowerbed.Length - 1 || flowerbed[currentPos + 1] == 0))
            {
                isPlant = Recursive(flowerbed, currentPos + 2, currentPlanted + 1, n);
            }

            var isNotPlant = Recursive(flowerbed, currentPos + 1, currentPlanted, n);

            return Math.Max(isPlant, isNotPlant);
        }

        /// <summary>
        /// Then move to the bottom up solution
        /// </summary>
        /// <param name="flowerbed"> Flowerbed </param>
        /// <param name="n"> Count of plants to place </param>
        /// <returns> True if possible </returns>
        public bool CanPlaceFlowersBottomUp(int[] flowerbed, int n)
        {
            var result = new int[flowerbed.Length + 2];

            for (var i = flowerbed.Length - 1; i >= 0; i--)
            {
                if (flowerbed[i] == 1)
                {
                    result[i] = result[i + 1];

                    continue;
                }

                var isPlant = 0;

                if ((i == 0 || flowerbed[i - 1] == 0) && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
                {
                    isPlant = result[i + 2] + 1;
                }

                var isNotPlant = result[i + 1];
                result[i] = Math.Max(isPlant, isNotPlant);
            }

            return result[0] >= n;
        }

        /// <summary>
        /// And optimize it.
        /// </summary>
        /// <param name="flowerbed"> Flowerbed </param>
        /// <param name="n"> Count of plants to place </param>
        /// <returns> True if possible </returns>
        public bool CanPlaceFlowersBottomUpOptimized(int[] flowerbed, int n)
        {
            var nextNextValue = 0;
            var nextValue = 0;

            for (var i = flowerbed.Length - 1; i >= 0; i--)
            {
                if (flowerbed[i] == 1)
                {
                    nextNextValue = nextValue;

                    continue;
                }

                var isPlant = 0;

                if ((i == 0 || flowerbed[i - 1] == 0) && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
                {
                    isPlant = nextNextValue + 1;
                }

                var isNotPlant = nextValue;
                nextNextValue = nextValue;
                nextValue = Math.Max(isPlant, isNotPlant);
            }

            return nextValue >= n;
        }
    }
}
