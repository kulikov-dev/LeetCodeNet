using System.Collections;
using LeetCodeNet.Easy.Strings;

namespace LeetCodeNet.Tests.Easy.Strings
{
    public sealed class LexicographicallySmallestPalindrome_2697_test
    {
        [Theory, ClassData(typeof(LexicographicallySmallestPalindromeTestData))]
        public void Check(string inputData, int expected)
        {
            var solver = new LexicographicallySmallestPalindrome_2697();
            var result = solver.MinLength(inputData);

            Assert.Equal(expected, result);
        }
    }

    public sealed class LexicographicallySmallestPalindromeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "ABFCACDB",
                2
            };

            yield return new object[]
            {
                "ACBBD",
                5
            };


        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
