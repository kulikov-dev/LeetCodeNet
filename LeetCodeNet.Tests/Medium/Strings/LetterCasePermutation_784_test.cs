using System.Collections;
using LeetCodeNet.Medium.Strings;

namespace LeetCodeNet.Tests.Medium.Strings
{
    public sealed class LetterCasePermutation_784_test
    {
        [Theory, ClassData(typeof(LetterCasePermutationTestData))]
        public void Check(string inputData, List<string> expected)
        {
            var solver = new LetterCasePermutation_784();

            Assert.True(expected.OrderBy(x=>x).SequenceEqual(solver.LetterCasePermutation(inputData).OrderBy(x=>x)));
        }
    }

    public sealed class LetterCasePermutationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "a1b2",
                new List<string>(){ "a1b2", "a1B2", "A1b2", "A1B2" }
            };

            yield return new object[]
            {
                "3z4",
                new List<string> { "3z4", "3Z4" }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
