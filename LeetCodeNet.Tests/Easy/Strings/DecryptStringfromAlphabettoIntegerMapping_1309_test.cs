using LeetCodeNet.Easy.Strings;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Strings
{
    public sealed class DecryptStringfromAlphabettoIntegerMapping_1309_test
    {
        [Theory, ClassData(typeof(DecryptStringfromAlphabettoIntegerMappingTestData))]
        public void Check(string inputData, string expected)
        {
            var solver = new DecryptStringfromAlphabettoIntegerMapping_1309();
            Assert.Equal(expected, solver.FreqAlphabets(inputData));
        }
    }

    public sealed class DecryptStringfromAlphabettoIntegerMappingTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "10#11#12",
                "jkab"
            };

            yield return new object[]
            {
                "1326#",
                "acz"
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}