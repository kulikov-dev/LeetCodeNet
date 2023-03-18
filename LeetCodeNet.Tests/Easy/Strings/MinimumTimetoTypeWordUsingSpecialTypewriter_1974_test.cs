using LeetCodeNet.Easy.Strings;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Strings
{
    public sealed class MinimumTimetoTypeWordUsingSpecialTypewriter_1974_test
    {
        [Theory, ClassData(typeof(MinimumTimetoTypeWordUsingSpecialTypewriterTestData))]
        public void Check(string inputData, int expected)
        {
            var solver = new MinimumTimetoTypeWordUsingSpecialTypewriter_1974();

            Assert.Equal(expected, solver.MinTimeToType(inputData));
        }
    }

    public sealed class MinimumTimetoTypeWordUsingSpecialTypewriterTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: For example, swap the first character with the last character of s2 to make "bank".
            yield return new object[]
            {
                "abc",
                5
            };

            //// Explanation: It is impossible to make them equal with one string swap.
            yield return new object[]
            {
                "bza",
                7
            };

            //// Explanation: The two strings are already equal, so no string swap operation is required.
            yield return new object[]
            {
                "zjpc",
                34
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}