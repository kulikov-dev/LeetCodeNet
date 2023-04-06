using LeetCodeNet.Easy.Strings;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Strings
{
    public sealed class IsomorphicStrings_205_test
    {
        [Theory, ClassData(typeof(IsomorphicStringsTestData))]
        public void Check(string inputData1, string inputData2, bool expected)
        {
            var solver = new IsomorphicStrings_205();

            Assert.Equal(expected, solver.IsIsomorphic(inputData1, inputData2));
        }
    }

    public sealed class IsomorphicStringsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "egg",
                "add",
                true
            };

            yield return new object[]
            {
                "foo",
                "bar",
                false
            };

            yield return new object[]
            {
                "paper",
                "title",
                true
            };

            yield return new object[]
            {
                "badc",
                "baba",
                false
            };

            yield return new object[]
            {
                "13",
                "42",
                true
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
