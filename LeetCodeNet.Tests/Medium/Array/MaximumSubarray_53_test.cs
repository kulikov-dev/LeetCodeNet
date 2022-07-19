using LeetCodeNet.Medium.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Medium.Array
{
    public class MaximumSubarray_53_test
    {
        [Theory, ClassData(typeof(MaximumSubarrayTestData))]
        public void CheckBruteForse(int[] inputData, int expected)
        {
            var solver = new MaximumSubarray_53();

            Assert.Equal(expected, solver.MaxSubArrayBruteForce(inputData));
        }

        [Theory, ClassData(typeof(MaximumSubarrayTestData))]
        public void CheckKadane(int[] inputData, int expected)
        {
            var solver = new MaximumSubarray_53();

            Assert.Equal(expected, solver.MaxSubArrayKadane(inputData));
        }
    }

    public class MaximumSubarrayTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: [4,-1,2,1] has the largest sum = 6.
            yield return new object[]
            {
                new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 },
                6
            };

            yield return new object[]
            {
                new int[] { 1 },
                1
            };

            yield return new object[]
            {
                new int[] { 5, 4, -1, 7, 8 },
                23
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
