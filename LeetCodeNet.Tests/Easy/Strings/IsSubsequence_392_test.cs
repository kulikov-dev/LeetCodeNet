using LeetCodeNet.Easy.Strings;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Strings
{
    public sealed class IsSubsequence_392_test
    {
        [Theory, ClassData(typeof(IsSubsequenceTestData))]
        public void Check(string inputData1, string inputData2, bool expected)
        {
            var solver = new IsSubsequence_392();

            Assert.Equal(expected, solver.IsSubsequence(inputData1, inputData2));
        }
    }

    public sealed class IsSubsequenceTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "abc",
                "ahbgdc",
                true
            };

            yield return new object[]
            {
                "axc",
                "ahbgdc",
                false
            };

            yield return new object[]
            {
                "aaaaaa",
                "bbaaaa",
                false
            };
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
