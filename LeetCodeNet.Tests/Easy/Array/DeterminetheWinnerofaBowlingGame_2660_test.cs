using System.Collections;
using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class DeterminetheWinnerofaBowlingGame_2660_test
    {
        [Theory, ClassData(typeof(DeterminetheWinnerofaBowlingGame))]
        public void Check(int[] inputData1, int[] inputData2, int expected)
        {
            var solver = new DeterminetheWinnerofaBowlingGame_2660();
            var result = solver.IsWinner(inputData1, inputData2);

            Assert.Equal(expected, result);
        }
    }

    public sealed class DeterminetheWinnerofaBowlingGame : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: The score of player1 is 4 + 10 + 2*7 + 2*9 = 46.
            /// The score of player2 is 6 + 5 + 2 + 3 = 16.
            /// Score of player1 is more than the score of player2, so, player1 is the winner, and the answer is 1.
            yield return new object[]
            {
                new []{4,10,7,9},
                new []{6,5,2,3},
                1
            };

            yield return new object[]
            {
                new []{3,5,7,6},
                new []{8,10,10,2},
                2
            };

            yield return new object[]
            {
                new []{2,3},
                new []{4,1},
                0
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
