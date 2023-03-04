using System.Collections;
using LeetCodeNet.Medium.Strings;

namespace LeetCodeNet.Tests.Medium.Strings
{
    public sealed class LongestSubstringWithoutRepeatingCharacters_3_test
    {
        [Theory, ClassData(typeof(LongestSubstringWithoutRepeatingCharactersTestData))]
        public void CheckRecursive(string inputData, int expected)
        {
            var solver = new LongestSubstringWithoutRepeatingCharacters_3();

            Assert.Equal(expected, solver.LengthOfLongestSubstring(inputData));
        }
    }

    public sealed class LongestSubstringWithoutRepeatingCharactersTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: The answer is "abc", with the length of 3.
            yield return new object[]
            {
                "abcabcbb",
                3
            };

            //// Explanation: The answer is "b", with the length of 1.
            yield return new object[]
            {
                "bbbbb",
                1
            };

            //// The answer is "wke", with the length of 3.
            /// Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
            yield return new object[]
            {
               "pwwkew",
               3
            };

            yield return new object[]
            {
                " ",
                1
            };

            yield return new object[]
            {
                "aab",
                2
            };

            yield return new object[]
            {
                "abba",
                2
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
