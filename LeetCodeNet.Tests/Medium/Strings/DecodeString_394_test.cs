using System.Collections;
using LeetCodeNet.Medium.Strings;

namespace LeetCodeNet.Tests.Medium.Strings
{
    public sealed class DecodeString_394_test
    {
        [Theory, ClassData(typeof(DecodeStringTestData))]
        public void CheckRecursive(string inputData, string expected)
        {
            var solver = new DecodeString_394();

            Assert.Equal(expected, solver.DecodeString(inputData));
        }
    }

    public sealed class DecodeStringTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "3[a]2[bc]",
                "aaabcbc"
            };

            yield return new object[]
            {
                "3[a2[c]]",
                "accaccacc"
            };

            yield return new object[]
            {
                "2[abc]3[cd]ef",
                "abcabccdcdcdef"
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
