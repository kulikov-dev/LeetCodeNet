using LeetCodeNet.Easy.Strings;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Strings
{
    public sealed class LongestPalindrome_409_test
    {
        [Theory, ClassData(typeof(LongestPalindromeTestData))]
        public void CheckSimple(string inputData, int expected)
        {
            var solver = new LongestPalindrome_409();

            Assert.Equal(expected, solver.LongestPalindromeSimple(inputData));
        }

        [Theory, ClassData(typeof(LongestPalindromeTestData))]
        public void CheckOptimized(string inputData, int expected)
        {
            var solver = new LongestPalindrome_409();

            Assert.Equal(expected, solver.LongestPalindromeOptimized(inputData));
        }
    }

    public sealed class LongestPalindromeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: One longest palindrome that can be built is "dccaccd", whose length is 7.
            yield return new object[]
            {
                "abccccdd",
                7
            };

            yield return new object[]
            {
                "a",
                1
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}