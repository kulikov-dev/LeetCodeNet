using LeetCodeNet.Easy.Strings;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Strings
{
    public class ReplaceAllDigitswithCharacters_1844_test
    {
        [Theory, ClassData(typeof(ReplaceAllDigitswithCharactersTestData))]
        public void Check(string inputData, string expected)
        {
            var solver = new ReplaceAllDigitswithCharacters_1844();
            Assert.Equal(expected, solver.ReplaceDigitsWithOriginal(inputData));
            Assert.Equal(expected, solver.ReplaceDigitsWithExceed(inputData));
        }

        [Fact]
        public void CheckExceed()
        {
            var solver = new ReplaceAllDigitswithCharacters_1844();
            Assert.Equal("zacdef", solver.ReplaceDigitsWithExceed("z1c1e1"));
        }
    }

    public class ReplaceAllDigitswithCharactersTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: The digits are replaced as follows:
            /// -s[1]->shift('a', 1) = 'b'
            /// - s[3]->shift('c', 1) = 'd'
            /// - s[5]->shift('e', 1) = 'f'
            yield return new object[]
            {
                "a1c1e1",
                "abcdef"
            };

            yield return new object[]
            {
                "a1b2c3d4e",
                "abbdcfdhe"
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
