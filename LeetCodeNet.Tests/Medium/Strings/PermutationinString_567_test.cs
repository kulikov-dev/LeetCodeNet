using System.Collections;
using LeetCodeNet.Medium.Strings;

namespace LeetCodeNet.Tests.Medium.Strings
{
    public sealed class PermutationinString_567_test
    {
        [Theory, ClassData(typeof(PermutationinStringTestData))]
        public void Check(string inputData1, string inputData2, bool expected)
        {
            var solver = new PermutationinString_567();

            Assert.Equal(expected, solver.CheckInclusion(inputData1, inputData2));
        }
    }

    public sealed class PermutationinStringTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "ab",
                "eidbaooo",
                true
            };

            yield return new object[]
            {
                "ab",
                "eidboaoo",
                false
            };

            yield return new object[]
            {
                "adc",
                "dcda",
                true
            };

            yield return new object[]
            {
                "ab",
                "a",
                false
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
