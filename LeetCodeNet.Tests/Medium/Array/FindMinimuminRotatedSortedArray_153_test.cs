using LeetCodeNet.Medium.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Medium.Array
{
    public sealed class FindMinimuminRotatedSortedArray_153_test
    {
        [Theory, ClassData(typeof(FindMinimuminRotatedSortedArrayTestData))]
        public void Check(int[] inputData, int expected)
        {
            var solver = new FindMinimuminRotatedSortedArray_153();

            Assert.Equal(expected, solver.FindMin(inputData));
        }
    }

    public sealed class FindMinimuminRotatedSortedArrayTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] { 3,4,5,1,2 },
                1
            };

            yield return new object[]
            {
                new[] { 4,5,6,7,0,1,2 },
                0
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
