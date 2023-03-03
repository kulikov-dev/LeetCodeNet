using System.Collections;
using LeetCodeNet.Medium.Strings;

namespace LeetCodeNet.Tests.Medium.Strings
{
    public sealed class FindAllAnagramsinaString_438_test
    {
        [Theory, ClassData(typeof(FindAllAnagramsinaStringTestData))]
        public void Check(string inputData1, string inputData2, List<int> expected)
        {
            var solver = new FindAllAnagramsinaString_438();

            Assert.True(expected.OrderBy(x => x).SequenceEqual(solver.FindAnagrams(inputData1, inputData2).OrderBy(x => x)));
        }
    }

    public sealed class FindAllAnagramsinaStringTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "cbaebabacd",
                "abc",
                new List<int>{0,6}
            };

            yield return new object[]
            {
                "abab",
                "ab",
                new List<int>{0,1,2}
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
