using LeetCodeNet.Easy.Strings;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Strings
{
    public sealed class ReverseVowelsofaString_345_test
    {
        [Theory, ClassData(typeof(ReverseVowelsofaStringTestData))]
        public void CheckTwoPass(string inputData, string expected)
        {
            var solver = new ReverseVowelsofaString_345();

            Assert.Equal(expected, solver.ReverseVowelsTwoPass(inputData));
        }

        [Theory, ClassData(typeof(ReverseVowelsofaStringTestData))]
        public void CheckTwoPointers(string inputData, string expected)
        {
            var solver = new ReverseVowelsofaString_345();

            Assert.Equal(expected, solver.ReverseVowelsTwoPointers(inputData));
        }
    }

    public sealed class ReverseVowelsofaStringTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "hello",
                "holle",
            };

            yield return new object[]
            {
                "leetcode",
                "leotcede"
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}