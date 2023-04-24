using System.Collections;
using LeetCodeNet.Easy.LeetMath;

namespace LeetCodeNet.Tests.Easy.LeetMath
{
    public sealed class SqrtX_69_test
    {
        [Theory, ClassData(typeof(SqrtXTestData))]
        public void Check(int inputData, int expected)
        {
            var solver = new SqrtX_69();
            var result = solver.MySqrt(inputData);

            Assert.Equal(expected, result);
        }
    }

    public sealed class SqrtXTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                4,
                2
            };

            yield return new object[]
            {
                0,
                0
            };

            //// Explanation: The square root of 8 is 2.82842..., and since we round it down to the nearest integer, 2 is returned.
            yield return new object[]
            {
                8,
                2
            };

            yield return new object[]
            {
                9,
                3
            };

            yield return new object[]
            {
                2147395599,
                46339
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
