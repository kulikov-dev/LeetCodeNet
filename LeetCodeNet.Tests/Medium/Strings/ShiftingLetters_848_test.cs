using System.Collections;
using LeetCodeNet.Medium.Strings;

namespace LeetCodeNet.Tests.Medium.Strings
{
    public sealed class ShiftingLetters_848_test
    {
        [Theory, ClassData(typeof(ShiftingLettersTestData))]
        public void CheckRecursive(string inputData1, int[] inputData2, string expected)
        {
            var solver = new ShiftingLetters_848();

            Assert.Equal(expected, solver.ShiftingLetters(inputData1, inputData2));
        }
    }

    public sealed class ShiftingLettersTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "abc",
                new [] { 3, 5, 9 },
                "rpl"
            };

            yield return new object[]
            {
                "aaa",
                new [] { 1,2,3 },
                "gfd"
            };

            yield return new object[]
            {
                "mkgfzkkuxownxvfvxasy",
                new [] { 505870226,437526072,266740649,224336793,532917782,311122363,567754492,595798950,81520022,684110326,137742843,275267355,856903962,148291585,919054234,467541837,622939912,116899933,983296461,536563513 },
                "wqqwlcjnkphhsyvrkdod"
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
