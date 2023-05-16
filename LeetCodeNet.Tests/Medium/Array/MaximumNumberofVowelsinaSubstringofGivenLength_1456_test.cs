using LeetCodeNet.Medium.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Medium.Array
{
    public sealed class MaximumNumberofVowelsinaSubstringofGivenLength_1456_test
    {
        [Theory, ClassData(typeof(MaximumNumberofVowelsinaSubstringofGivenLengthTestData))]
        public void CheckSimple(string inputData1, int inputData2, int expected)
        {
            var solver = new MaximumNumberofVowelsinaSubstringofGivenLength_1456();

            Assert.Equal(expected, solver.MaxVowelsSimple(inputData1, inputData2));
        }

        [Theory, ClassData(typeof(MaximumNumberofVowelsinaSubstringofGivenLengthTestData))]
        public void CheckOptimized(string inputData1, int inputData2, int expected)
        {
            var solver = new MaximumNumberofVowelsinaSubstringofGivenLength_1456();

            Assert.Equal(expected, solver.MaxVowelsOptimized(inputData1, inputData2));
        }
    }

    public sealed class MaximumNumberofVowelsinaSubstringofGivenLengthTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "abciiidef",
                3,
                3
            };

            yield return new object[]
            {
                "aeiou",
                2,
                2
            };
            
            yield return new object[]
            {
                "leetcode",
                3,
                2
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
