using LeetCodeNet.Medium.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Medium.Array
{
    public sealed class PeakIndexinaMountainArray_852_test
    {
        [Theory, ClassData(typeof(PeakIndexinaMountainArrayTestData))]
        public void Check(int[] inputData, int expected)
        {
            var solver = new PeakIndexinaMountainArray_852();

            Assert.Equal(expected, solver.PeakIndexInMountainArray(inputData));
        }
    }

    public sealed class PeakIndexinaMountainArrayTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] { 0,1,0 },
                1
            };
            
            yield return new object[]
            {
                new[] { 0,2,1,0 },
                1
            };
            
            yield return new object[]
            {
                new[] { 0,10,5,2 },
                1
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
