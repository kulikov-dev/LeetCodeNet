using System.Collections;
using LeetCodeNet.Medium.Strings;

namespace LeetCodeNet.Tests.Medium.Strings
{
    public sealed class LexicographicallySmallestStringAfterSubstringOperation_2734_test
    {
        [Theory, ClassData(typeof(LexicographicallySmallestStringAfterSubstringOperationTestData))]
        public void Check(string inputData, string expected)
        {
            var solver = new LexicographicallySmallestStringAfterSubstringOperation_2734();

            Assert.Equal(expected, solver.SmallestString(inputData));
        }
    }

    public sealed class LexicographicallySmallestStringAfterSubstringOperationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "a",
                "z"
            };

            yield return new object[]
            {
                "aaaa",
                "aaaz"
            };

            yield return new object[]
            {
                "aaaab",
                "aaaaa"
            };

            yield return new object[]
            {
                "cbabc",
                "baabc"
            };

            yield return new object[]
            {
                "acbbc",
                "abaab"
            };

            yield return new object[]
            {
                "leetcode",
                "kddsbncd"
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
