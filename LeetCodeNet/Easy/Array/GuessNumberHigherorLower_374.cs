namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/guess-number-higher-or-lower
    /// </summary>
    /// <remarks>
    /// We are playing the Guess Game. The game is as follows:
    /// I pick a number from 1 to n.You have to guess which number I picked.
    /// Every time you guess wrong, I will tell you whether the number I picked is higher or lower than your guess.
    /// You call a pre-defined API int guess(int num), which returns three possible results:
    /// -1: Your guess is higher than the number I picked (i.e.num > pick).
    /// 1: Your guess is lower than the number I picked(i.e.num<pick).
    /// 0: your guess is equal to the number I picked(i.e.num == pick).
    /// Return the number that I picked.
    /// </remarks>
    internal sealed class GuessNumberHigherorLower_374
    {
        /// <summary>
        /// Treat this as a usual sorted array. To find the item in the sorted array the best idea is to use BinarySearch
        /// </summary>
        /// <param name="n"> Max amount of numbers </param>
        /// <param name="guesser"> API </param>
        /// <returns> Guessed num </returns>
        /// <remarks>
        /// Time complexity: O(log n)
        /// Space complexity: O(1)
        /// </remarks>
        public int GuessNumber(int n, IGuesser guesser)
        {
            var leftIndex = 1;
            var rightIndex = n;

            while (leftIndex < rightIndex)
            {
                var currentNum = leftIndex + (rightIndex - leftIndex) / 2;
                var guessResult = guesser.Guess(currentNum);

                if (guessResult == 0)
                {
                    return currentNum;
                }

                if (guessResult == -1)
                {
                    rightIndex = currentNum;
                }
                else
                {
                    leftIndex = currentNum + 1;
                }
            }

            return leftIndex;
        }

        /// <summary>
        /// Interface for an API tool
        /// </summary>
        public interface IGuesser
        {
            /// <summary>
            /// Check if number is guessed
            /// </summary>
            /// <param name="num"> Current number </param>
            /// <returns> Guess result: 0 = guess, -1 is less, 1 is more </returns>
            int Guess(int num);
        }
    }
}
