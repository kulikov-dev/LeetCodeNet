using LeetCodeNet.Medium.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Medium.Array
{
    public sealed class MaximumDistanceBetweenaPairofValues_1855_test
    {
        [Theory, ClassData(typeof(MaximumDistanceBetweenaPairofValuesTestData))]
        public void CheckTwoPass( int[] inputData1, int[] inputData2, int expected)
        {
            var solver = new MaximumDistanceBetweenaPairofValues_1855();

            Assert.Equal(expected, solver.MaxDistance(inputData1, inputData2));
        }
    }

    public sealed class MaximumDistanceBetweenaPairofValuesTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: The valid pairs are (0,0), (2,2), (2,3), (2,4), (3,3), (3,4), and (4,4).
            /// The maximum distance is 2 with pair(2,4).
            yield return new object[]
            {
                new[] {55,30,5,4,2},
                new[] {100,20,10,10,5},
                2
            };

            yield return new object[]
            {
                new[] {2, 2, 2},
                new[] {10, 10 ,1 },
                1
            };

            //// Explanation: The valid pairs are (2,2), (2,3), (2,4), (3,3), and (3,4).
            /// The maximum distance is 2 with pair(2,4).
            yield return new object[]
            {
                new[] {30,29,19,5},
                new[] {25,25,25,25,25},
                2
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
