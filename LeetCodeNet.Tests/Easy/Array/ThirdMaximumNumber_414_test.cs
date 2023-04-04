using LeetCodeNet.Easy.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class ThirdMaximumNumber_414_test
    {
        [Theory, ClassData(typeof(ThirвMaximumNumberTestData))]
        public void CheckLinq(int[] inputData, int expected)
        {
            var solver = new ThirdMaximumNumber_414();

            Assert.Equal(expected, solver.ThirdMaxLinq(inputData));
        }

        [Theory, ClassData(typeof(ThirвMaximumNumberTestData))]
        public void CheckMax(int[] inputData, double expected)
        {
            var solver = new ThirdMaximumNumber_414();

            Assert.Equal(expected, solver.ThirdMaxByValue(inputData));
        }
    }

    public sealed class ThirвMaximumNumberTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] { 3,2,1 },
                1
            };

            yield return new object[]
            {
                new[] { 1,2 },
                2
            };

            yield return new object[]
            {
                new[] { 2,2,3,1 },
                1
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}