using System.Collections;
using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class BinarySearch_704_test
    {
        [Theory, ClassData(typeof(BinarySearchTestData))]
        public void CheckBFS(int[] inputData1, int inputData2, int expected)
        {
            var solver = new BinarySearch_704();
            var result = solver.Search(inputData1, inputData2);

            Assert.Equal(expected, result);
        }
    }

    public sealed class BinarySearchTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: 9 exists in nums and its index is 4
            yield return new object[]
            {
                new []{-1,0,3,5,9,12},
                9,
                4
            };

            //// Explanation: 2 does not exist in nums so return -1
            yield return new object[]
            {
                new []{-1,0,3,5,9,12},
                2,
                -1
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
