using System.Collections;
using LeetCodeNet.Medium.Strings;

namespace LeetCodeNet.Tests.Medium.Strings
{
    public sealed class BreakaPalindrome_1328_test
    {
        [Theory, ClassData(typeof(BreakaPalindromeTestData))]
        public void Check(string inputData, string expected)
        {
            var solver = new BreakaPalindrome_1328();

            Assert.Equal(expected, solver.BreakPalindrome(inputData));
        }
    }

    public sealed class BreakaPalindromeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// There are many ways to make "abccba" not a palindrome, such as "zbccba", "aaccba", and "abacba". Of all the ways, "aaccba" is the lexicographically smallest.
            yield return new object[]
            {
                "abccba",
                "aaccba"
            };

            yield return new object[]
            {
                "a",
                string.Empty
            };

            yield return new object[]
            {
                "aaaaaa",
                "aaaaab"
            };

            yield return new object[]
            {
                "aaaaa",
                "aaaab"
            };

            yield return new object[]
            {
                "z",
                string.Empty
            };

            yield return new object[]
            {
                "aba",
                "abb"
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
