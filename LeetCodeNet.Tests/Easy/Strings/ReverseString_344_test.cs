using LeetCodeNet.Easy.Strings;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Strings
{
    public class ReverseString_344_test
    {
        [Theory, ClassData(typeof(ReverseStringTestData))]
        public void Check(char[] inputData, char[] expected)
        {
            var solver = new ReverseString_344();
            solver.ReverseString(inputData);
            Assert.Equal(expected, inputData);
        }
    }

    public class ReverseStringTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new char[] {'h','e','l','l','o'},
                new char[] {'o','l','l','e','h'},
            };

            yield return new object[]
            {
                new char[] {'H','a','n','n','a','h'},
                new char[] {'h','a','n','n','a','H'},
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
