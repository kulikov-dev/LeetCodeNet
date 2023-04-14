using System.Collections;
using LeetCodeNet.Medium.DP;

namespace LeetCodeNet.Tests.Medium.DP
{
    public sealed class LongestPalindromicSubsequence_516_test
    {
        [Theory, ClassData(typeof(LongestPalindromicSubsequenceTestData))]
        public void CheckRecursive(string inputData, int expected)
        {
            var solver = new LongestPalindromicSubsequence_516();

            Assert.Equal(expected, solver.LongestPalindromeSubseqRecursive(inputData));
        }

        [Theory, ClassData(typeof(LongestPalindromicSubsequenceTestData))]
        public void CheckBottomUp(string inputData, int expected)
        {
            var solver = new LongestPalindromicSubsequence_516();

            Assert.Equal(expected, solver.LongestPalindromeSubseqBottomUp(inputData));
        }

        [Theory, ClassData(typeof(LongestPalindromicSubsequenceTestData))]
        public void CheckBottomUpMemo(string inputData, int expected)
        {
            var solver = new LongestPalindromicSubsequence_516();

            Assert.Equal(expected, solver.LongestPalindromeSubseqBottomUpMemo(inputData));
        }
    }

    public sealed class LongestPalindromicSubsequenceTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: One possible longest palindromic subsequence is "bbbb".
            yield return new object[]
            {
                "bbbab",
                4
            };

            //// Explanation: One possible longest palindromic subsequence is "bb".
            yield return new object[]
            {
                "cbbd",
                2
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}