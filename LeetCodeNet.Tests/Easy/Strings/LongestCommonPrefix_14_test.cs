using LeetCodeNet.Easy.Strings;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Strings
{
    public class LongestCommonPrefix_14_test
    {
        [Theory, ClassData(typeof(LongestCommonPrefixTestData))]
        public void CheckLoop(string[] inputData, string expected)
        {
            var solver = new LongestCommonPrefix_14();
            Assert.Equal(expected, solver.LongestCommonPrefixLoop(inputData));
        }

        [Theory, ClassData(typeof(LongestCommonPrefixTestData))]
        public void CheckSort(string[] inputData, string expected)
        {
            var solver = new LongestCommonPrefix_14();
            Assert.Equal(expected, solver.LongestCommonPrefixLoop(inputData));
        }
    }

    public class LongestCommonPrefixTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new string[] { "flower","flow","flight"},
                "fl"
            };

            //// Explanation: There is no common prefix among the input strings.
            yield return new object[]
            {
                new string[] { "dog","racecar","car"},
                string.Empty
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
