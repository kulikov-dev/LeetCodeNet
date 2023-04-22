using System.Collections;
using LeetCodeNet.Easy.Array;
using Moq;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class GuessNumberHigherorLower_374_test
    {
        [Theory, ClassData(typeof(GuessNumberHigherorLowerTestData))]
        public void Check(int inputData1, Mock inputData2, int expected)
        {
            var solver = new GuessNumberHigherorLower_374();
            var result = solver.GuessNumber(inputData1, inputData2.Object as GuessNumberHigherorLower_374.IGuesser);

            Assert.Equal(expected, result);
        }
    }

    public sealed class GuessNumberHigherorLowerTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var mock = new Mock<GuessNumberHigherorLower_374.IGuesser>();

            mock.Setup(x => x.Guess(1)).Returns(1);
            mock.Setup(x => x.Guess(2)).Returns(1);
            mock.Setup(x => x.Guess(3)).Returns(1);
            mock.Setup(x => x.Guess(4)).Returns(1);
            mock.Setup(x => x.Guess(5)).Returns(1);
            mock.Setup(x => x.Guess(6)).Returns(0);
            mock.Setup(x => x.Guess(7)).Returns(-1);
            mock.Setup(x => x.Guess(8)).Returns(-1);
            mock.Setup(x => x.Guess(9)).Returns(-1);
            mock.Setup(x => x.Guess(10)).Returns(-1);
            yield return new object[]
            {
                10,
                mock,
                6
            };

            mock = new Mock<GuessNumberHigherorLower_374.IGuesser>();

            mock.Setup(x => x.Guess(1)).Returns(0);

            yield return new object[]
            {
                1,
                mock,
                1
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}