using System.Collections;
using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class FindLuckyIntegerinanArray_1394_test
    {
        [Theory, ClassData(typeof(FindLuckyIntegerinanArrayTestData))]
        public void CheckArray(int[] inputData, int expected)
        {
            var solver = new FindLuckyIntegerinanArray_1394();
            var result = solver.FindLuckyArray(inputData);

            Assert.Equal(expected, result);
        }

        [Theory, ClassData(typeof(FindLuckyIntegerinanArrayTestData))]
        public void CheckDict(int[] inputData, int expected)
        {
            var solver = new FindLuckyIntegerinanArray_1394();
            var result = solver.FindLuckyDict(inputData);

            Assert.Equal(expected, result);
        }
    }

    public sealed class FindLuckyIntegerinanArrayTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new []{2,2,3,4},
                2
            };

            yield return new object[]
            {
                new []{1,2,2,3,3,3},
                3
            };

            yield return new object[]
            {
                new []{2,2,2,3,3},
                -1
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
