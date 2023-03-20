using LeetCodeNet.Medium.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Medium.Array
{
    public sealed class TopKFrequentElements_347_test
    {
        [Theory, ClassData(typeof(TopKFrequentElementsTestData))]
        public void CheckLinq(int[] input1, int input2, int[] expected)
        {
            var solver = new TopKFrequentElements_347();

            var result = solver.TopKFrequentLinq(input1, input2);

            Assert.True(expected.SequenceEqual(result));
        }

        [Theory, ClassData(typeof(TopKFrequentElementsTestData))]
        public void CheckSort(int[] input1, int input2, int[] expected)
        {
            var solver = new TopKFrequentElements_347();

            var result = solver.TopKFrequentSort(input1, input2);

            Assert.True(expected.SequenceEqual(result));
        }
    }

    public sealed class TopKFrequentElementsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] {1,1,1,2,2,3},
               2,
               new[] {1,2}
            };

            yield return new object[]
            {
                new[] {1},
                1,
                new[] {1}
            };
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
