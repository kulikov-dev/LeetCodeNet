using System.Collections;
using LeetCodeNet.Medium.Strings;

namespace LeetCodeNet.Tests.Medium.Strings
{
    public sealed class LongestPalindromicSubstring_5_test
    {
        [Theory, ClassData(typeof(LongestPalindromicSubstringTestData))]
        public void CheckRecursive(string inputData, string expected)
        {
            var solver = new LongestPalindromicSubstring_5();

            Assert.Equal(expected, solver.LongestPalindrome(inputData));
        }
    }

    public sealed class LongestPalindromicSubstringTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "babad",
                "bab"
            };

            yield return new object[]
            {
                "cbbd",
                "bb"
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
