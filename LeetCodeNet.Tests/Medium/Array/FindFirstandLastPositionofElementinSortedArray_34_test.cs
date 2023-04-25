using LeetCodeNet.Medium.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Medium.Array
{
    public sealed class FindFirstandLastPositionofElementinSortedArray_34_test
    {
        [Theory, ClassData(typeof(FindFirstandLastPositionofElementinSortedArrayTestData))]
        public void Check(int[] inputData1, int inputData2, int[] expected)
        {
            var solver = new FindFirstandLastPositionofElementinSortedArray_34();
            var result = solver.SearchRange(inputData1, inputData2);

            Assert.True(expected.SequenceEqual(result));
        }
    }

    public sealed class FindFirstandLastPositionofElementinSortedArrayTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] { 5,7,7,8,8,10 },
                8,
                new [] {3,4}
            };

            yield return new object[]
            {
                new[] { 5,7,7,8,8,10 },
                6,
                new [] {-1 , -1}
            };

            yield return new object[]
            {
                System.Array.Empty<int>(),
                8,
                new [] {-1, -1}
            };

            yield return new object[]
            {
                new[] { 1, 4 },
                4,
                new [] {1, 1}
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
