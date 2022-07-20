using LeetCodeNet.Easy.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Array
{
    public class SumofAllOddLengthSubarrays_1588_test
    {
        [Theory, ClassData(typeof(SumofAllOddLengthSubarraysTestData))]
        public void CheckBruteForce(int[] inputData, int expected)
        {
            var solver = new SumofAllOddLengthSubarrays_1588();
            Assert.Equal(expected, solver.SumOddLengthSubarraysBruteForce(inputData));
        }

        [Theory, ClassData(typeof(SumofAllOddLengthSubarraysTestData))]
        public void CheckMath(int[] inputData, int expected)
        {
            var solver = new SumofAllOddLengthSubarrays_1588();
            Assert.Equal(expected, solver.SumOddLengthSubarraysMath(inputData));
        }
    }

    public class SumofAllOddLengthSubarraysTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: The odd-length subarrays of arr and their sums are:
            /// [1] = 1
            /// [4] = 4
            /// [2] = 2
            /// [5] = 5
            /// [3] = 3
            /// [1, 4, 2] = 7
            /// [4, 2, 5] = 11
            /// [2, 5, 3] = 10
            /// [1, 4, 2, 5, 3] = 15
            /// If we add all these together we get 1 + 4 + 2 + 5 + 3 + 7 + 11 + 10 + 15 = 58
            yield return new object[]
            {
                new int[] { 1,4,2,5,3 },
                58
            };

            //// Explanation: There are only 2 subarrays of odd length, [1] and [2]. Their sum is 3.
            yield return new object[]
            {
                new int[] { 1, 2 },
                3
            };

            yield return new object[]
            {
                new int[] { 10, 11, 12 },
                66
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}