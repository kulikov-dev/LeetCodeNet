using System.Collections;
using LeetCodeNet.Medium.LeetMath;

namespace LeetCodeNet.Tests.Medium.LeetMath
{
    public sealed class NumberofZero_FilledSubarrays_2348_test
    {
        [Theory, ClassData(typeof(NumberofZero_FilledSubarraysTestData))]
        public void Check(int[] inputData, long expected)
        {
            var solver = new NumberofZero_FilledSubarrays_2348();

            Assert.Equal(expected, solver.ZeroFilledSubarray(inputData));
        }
    }

    public sealed class NumberofZero_FilledSubarraysTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation:
            /// There are 4 occurrences of[0] as a subarray.
            /// There are 2 occurrences of[0, 0] as a subarray.
            /// There is no occurrence of a subarray with a size more than 2 filled with 0.Therefore, we return 6.
            yield return new object[]
            {
                new[] { 1,3,0,0,2,0,0,4 },
                6
            };

            //// Explanation:
            /// There are 5 occurrences of[0] as a subarray.
            /// There are 3 occurrences of[0, 0] as a subarray.
            /// There is 1 occurrence of[0, 0, 0] as a subarray.
            /// There is no occurrence of a subarray with a size more than 3 filled with 0.Therefore, we return 9.
            yield return new object[]
            {
                new[] { 0,0,0,2,0,0 },
                9
            };

            yield return new object[]
            {
                new[] { 5, 4, -1, 7, 8 },
                0
            };

            yield return new object[]
            {
                new[] { 0, 0, 0, 0, 0, 0 },
                21
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
