namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/determine-the-winner-of-a-bowling-game/
    /// </summary>
    /// <remarks>
    /// You are given two 0-indexed integer arrays player1 and player2, that represent the number of pins that player 1 and player 2 hit in a bowling game, respectively.
    /// The bowling game consists of n turns, and the number of pins in each turn is exactly 10.
    /// Assume a player hit xi pins in the ith turn.The value of the ith turn for the player is:
    /// 2xi if the player hit 10 pins in any of the previous two turns.
    /// Otherwise, It is xi.
    /// The score of the player is the sum of the values of their n turns.
    /// Return
    /// 1 if the score of player 1 is more than the score of player 2,
    /// 2 if the score of player 2 is more than the score of player 1, and
    /// 0 in case of a draw.
    /// </remarks>
    internal sealed class DeterminetheWinnerofaBowlingGame_2660
    {
        /// <summary>
        /// Straight solution where we need to calculate scores for each player and get the result
        /// </summary>
        /// <param name="player1"> Player 1 scores </param>
        /// <param name="player2"> Player 2 scores </param>
        /// <returns> Winner </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public int IsWinner(int[] player1, int[] player2)
        {
            var score1 = CalcScores(player1);
            var score2 = CalcScores(player2);

            if (score1 > score2)
            {
                return 1;
            }

            return score2 > score1 ? 2 : 0;
        }

        /// <summary>
        /// Support void to calc scores
        /// </summary>
        /// <param name="player"> Player scores </param>
        /// <returns> Total score </returns>
        private int CalcScores(IReadOnlyList<int> player)
        {
            var result = 0;

            for (var i = 0; i < player.Count; i++)
            {
                switch (i)
                {
                    //// Check if one of the two previous values is equal to 10, then multiply the current score.
                    case >= 1 when player[i - 1] == 10:
                    case >= 2 when player[i - 2] == 10:
                        result += player[i] * 2;
                        break;
                    default:
                        result += player[i];
                        break;
                }
            }

            return result;
        }
    }
}
