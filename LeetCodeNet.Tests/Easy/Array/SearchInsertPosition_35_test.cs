using System.Collections;
using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class SearchInsertPosition_35_test
    {
        [Theory, ClassData(typeof(SearchInsertPositionTestData))]
        public void CheckBFS(int[] inputData1, int inputData2, int expected)
        {
            var solver = new SearchInsertPosition_35();
            var result = solver.SearchInsert(inputData1, inputData2);

            Assert.Equal(expected, result);
        }
    }

    public sealed class SearchInsertPositionTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new []{1,3,5,6},
                5,
                2
            };

            yield return new object[]
            {
                new []{1,3,5,6},
                2,
                1
            };

            yield return new object[]
            {
                new []{1,3,5,6},
                7,
                4
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
