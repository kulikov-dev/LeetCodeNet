using LeetCodeNet.Medium.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Medium.Array
{
    public sealed class SearchinRotatedSortedArray_33_test
    {
        [Theory, ClassData(typeof(SearchinRotatedSortedArrayTestData))]
        public void Check(int[] input1, int input2, int expected)
        {
            var solver = new SearchinRotatedSortedArray_33();

            var result = solver.Search(input1, input2);

            Assert.Equal(expected, result);
        }
    }

    public sealed class SearchinRotatedSortedArrayTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] {4,5,6,7,0,1,2},
               0,
              4
            };

            yield return new object[]
            {
                new[] {4,5,6,7,0,1,2},
                3,
                -1
            };

            yield return new object[]
            {
                new[] {1},
                0,
                -1
            };

            yield return new object[]
            {
                new[] {0},
                0,
                0
            };

            yield return new object[]
            {
                new[] {1,2,3,4,5,6,7,8},
                3,
                2
            };

            yield return new object[]
            {
                new[] {3, 5, 1},
                3,
                0
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
