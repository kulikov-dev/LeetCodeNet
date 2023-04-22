using System.Collections;
using LeetCodeNet.Easy.Array;
using Moq;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class FirstBadVersion_278_test
    {
        [Theory, ClassData(typeof(FirstBadVersionTestData))]
        public void Check(int inputData1, Mock inputData2, int expected)
        {
            var solver = new FirstBadVersion_278();
            var result = solver.FirstBadVersion(inputData1, inputData2.Object as IBadVersionChecker);

            Assert.Equal(expected, result);
        }
    }

    public sealed class FirstBadVersionTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var mock = new Mock<IBadVersionChecker>();

            mock.Setup(x => x.IsBadVersion(1)).Returns(false);
            mock.Setup(x => x.IsBadVersion(2)).Returns(false);
            mock.Setup(x => x.IsBadVersion(3)).Returns(false);
            mock.Setup(x => x.IsBadVersion(4)).Returns(true);
            mock.Setup(x => x.IsBadVersion(5)).Returns(true);
            yield return new object[]
            {
                5,
                mock,
                4
            };

            mock = new Mock<IBadVersionChecker>();

            mock.Setup(x => x.IsBadVersion(1)).Returns(true);

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