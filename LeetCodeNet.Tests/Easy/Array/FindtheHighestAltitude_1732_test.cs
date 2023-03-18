using LeetCodeNet.Easy.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class FindtheHighestAltitude_1732_test
    {
        [Theory, ClassData(typeof(FindtheHighestAltitudeTestData))]
        public void Check(int[] inputData, int expected)
        {
            var solver = new FindtheHighestAltitude_1732();
            var result = solver.LargestAltitude(inputData);

            Assert.Equal(expected, result);
        }
    }

    public sealed class FindtheHighestAltitudeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: The altitudes are [0,-5,-4,1,1,-6]. The highest is 1.
            yield return new object[]
            {
                new []{-5,1,5,0,-7},
                1
            };

            //// Explanation: The altitudes are [0,-4,-7,-9,-10,-6,-3,-1]. The highest is 0.
            yield return new object[]
            {
                new []{-4,-3,-2,-1,4,3,2},
                0
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
