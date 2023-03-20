using LeetCodeNet.Easy.Strings;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Strings
{
    public sealed class ReverseString_344_test
    {
        [Theory, ClassData(typeof(ReverseStringTestData))]
        public void Check(char[] inputData, char[] expected)
        {
            var solver = new ReverseString_344();

            solver.ReverseString(inputData);
            Assert.Equal(expected, inputData);
        }
    }

    public sealed class ReverseStringTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] {'h','e','l','l','o'},
                new[] {'o','l','l','e','h'},
            };

            yield return new object[]
            {
                new[] {'H','a','n','n','a','h'},
                new[] {'h','a','n','n','a','H'},
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
