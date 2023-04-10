using LeetCodeNet.Easy.Strings;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Strings
{
    public sealed class ValidParentheses_20_test
    {
        [Theory, ClassData(typeof(ValidParenthesesTestData))]
        public void CheckSimple(string inputData, bool expected)
        {
            var solver = new ValidParentheses_20();

            Assert.Equal(expected, solver.IsValidSimple(inputData));
        }

        [Theory, ClassData(typeof(ValidParenthesesTestData))]
        public void CheckAnyChar(string inputData, bool expected)
        {
            var solver = new ValidParentheses_20();

            Assert.Equal(expected, solver.IsValidAnyCharacters(inputData));
        }
    }

    public sealed class ValidParenthesesTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "()",
                true
            };

            yield return new object[]
            {
                "()[]{}",
                true
            };

            yield return new object[]
            {
                "(]",
                false
            };

            yield return new object[]
            {
                "]",
                false
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}