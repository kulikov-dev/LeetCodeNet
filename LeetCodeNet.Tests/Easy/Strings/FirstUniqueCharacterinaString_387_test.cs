using LeetCodeNet.Easy.Strings;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Strings
{
    public sealed class FirstUniqueCharacterinaString_387_test
    {
        [Theory, ClassData(typeof(FirstUniqueCharacterinaStringTestData))]
        public void CheckArray(string inputData, int expected)
        {
            var solver = new FirstUniqueCharacterinaString_387();
            Assert.Equal(expected, solver.FirstUniqCharArray(inputData));
        }
    }

    public sealed class FirstUniqueCharacterinaStringTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "leetcode",
                0
            };

            yield return new object[]
            {
                "loveleetcode",
                2
            };

            yield return new object[]
            {
                "aabb",
                -1
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
