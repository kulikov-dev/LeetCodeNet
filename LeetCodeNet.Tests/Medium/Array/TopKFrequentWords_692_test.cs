using LeetCodeNet.Medium.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Medium.Array
{
    public sealed class TopKFrequentWords_692_test
    {
        [Theory, ClassData(typeof(TopKFrequentWordsTestData))]
        public void CheckSort(string[] inputData1, int inputData2, string[] expected)
        {
            var solver = new TopKFrequentWords_692();
            var result = solver.TopKFrequentLinq(inputData1, inputData2);

            Assert.True(expected.SequenceEqual(result));
        }

        [Theory, ClassData(typeof(TopKFrequentWordsTestData))]
        public void CheckBucket(string[] inputData1, int inputData2, string[] expected)
        {
            var solver = new TopKFrequentWords_692();
            var result = solver.TopKFrequentBucket(inputData1, inputData2);

            Assert.True(expected.SequenceEqual(result));
        }
    }

    public sealed class TopKFrequentWordsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] { "i","love","leetcode","i","love","coding" },
                2,
                new[] { "i","love"}
            };

            yield return new object[]
            {
                new[] { "the","day","is","sunny","the","the","the","sunny","is","is" },
                4,
                new[] { "the", "is", "sunny", "day" }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
