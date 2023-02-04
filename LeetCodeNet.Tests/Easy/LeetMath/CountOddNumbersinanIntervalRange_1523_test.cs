using System.Collections;
using LeetCodeNet.Easy.LeetMath;

namespace LeetCodeNet.Tests.Easy.LeetMath
{
    public sealed class CountOddNumbersinanIntervalRange_1523_test
    {
        [Theory, ClassData(typeof(CountOddNumbersinanIntervalRangeTestData))]
        public void CheckSimple(int low, int high, int expected)
        {
            var solver = new CountOddNumbersinanIntervalRange_1523();
            var result = solver.CountOdds(low,high);

            Assert.Equal(expected, result);
        }
    }

    public sealed class CountOddNumbersinanIntervalRangeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                3, 7, 3
            };

            yield return new object[]
            {
                8, 10, 1
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
