using System.Collections;
using LeetCodeNet.Easy.Strings;

namespace LeetCodeNet.Tests.Easy.Strings
{
    public sealed class MinimumStringLengthAfterRemovingSubstrings_2696_test
    {
        [Theory, ClassData(typeof(MinimumStringLengthAfterRemovingSubstringsTestData))]
        public void Check(string inputData, string expected)
        {
            var solver = new MinimumStringLengthAfterRemovingSubstrings_2696();
            var result = solver.MakeSmallestPalindrome(inputData);

            Assert.Equal(expected, result);
        }
    }

    public sealed class MinimumStringLengthAfterRemovingSubstringsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "egcfe",
                "efcfe"
            };

            yield return new object[]
            {
                "abcd",
                "abba"
            };

            yield return new object[]
            {
                "seven",
                "neven"
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
