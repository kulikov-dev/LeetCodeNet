using System.Collections;
using LeetCodeNet.Easy.Strings;

namespace LeetCodeNet.Tests.Easy.Strings
{
    public sealed class MinimizeStringLength_2716_test
    {
        [Theory, ClassData(typeof(MinimizeStringLengthTestData))]
        public void CheckHash(string inputData, int expected)
        {
            var solver = new MinimizeStringLength_2716();

            Assert.Equal(expected, solver.MinimizedStringLengthHash(inputData));
        }

        [Theory, ClassData(typeof(MinimizeStringLengthTestData))]
        public void CheckLinq(string inputData, int expected)
        {
            var solver = new MinimizeStringLength_2716();

            Assert.Equal(expected, solver.MinimizedStringLengthLinq(inputData));
        }
    }

    public sealed class MinimizeStringLengthTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "aaabc",
                3
            };

            yield return new object[]
            {
                "cbbd",
                3
            };

            yield return new object[]
            {
                "dddaaa",
                2
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
