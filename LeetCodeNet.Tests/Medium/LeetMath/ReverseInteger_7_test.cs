using System.Collections;
using LeetCodeNet.Medium.LeetMath;

namespace LeetCodeNet.Tests.Medium.LeetMath
{
    public sealed class ReverseInteger_7_test
    {
        [Theory, ClassData(typeof(ReverseIntegerTestData))]
        public void CheckSimple(int inputData, int expected)
        {
            var solver = new ReverseInteger_7();
            var result = solver.ReverseSimple(inputData);

            Assert.Equal(expected, result);
        }

        [Theory, ClassData(typeof(ReverseIntegerTestData))]
        public void CheckWithoutLong(int inputData, int expected)
        {
            var solver = new ReverseInteger_7();
            var result = solver.ReverseWithoutLong(inputData);

            Assert.Equal(expected, result);
        }
    }

    public sealed class ReverseIntegerTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                123,
                321
            };

            yield return new object[]
            {
                -123,
                -321
            };

            yield return new object[]
            {
                120,
                21
            };

            yield return new object[]
            {
                1534236469,
                0
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
