using System.Collections;
using LeetCodeNet.Medium.Strings;

namespace LeetCodeNet.Tests.Medium.Strings
{
    public sealed class LongestRepeatingCharacterReplacement_424_test
    {
        [Theory, ClassData(typeof(LongestRepeatingCharacterReplacementTestData))]
        public void Check(string inputData1, int inputData2, int expected)
        {
            var solver = new LongestRepeatingCharacterReplacement_424();

            Assert.Equal(expected, solver.CharacterReplacement(inputData1, inputData2));
        }
    }

    public sealed class LongestRepeatingCharacterReplacementTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "ABAB",
                2,
                4
            };

            yield return new object[]
            {
                "AABABBA",
                1,
                4
            };
            yield return new object[]
            {
                "ABAA",
                0,
                2
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
