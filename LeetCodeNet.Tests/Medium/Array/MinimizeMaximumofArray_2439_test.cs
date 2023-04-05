using LeetCodeNet.Medium.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Medium.Array
{
    public sealed class MinimizeMaximumofArray_2439_test
    {
        [Theory, ClassData(typeof(MinimizeMaximumofArrayTestData))]
        public void Check(int[] inputData, int expected)
        {
            var solver = new MinimizeMaximumofArray_2439();

            Assert.Equal(expected, solver.MinimizeArrayValue(inputData));
        }
    }

    public sealed class MinimizeMaximumofArrayTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation:
            /// One set of optimal operations is as follows:
            /// 1.Choose i = 1, and nums becomes[4, 6, 1, 6].
            /// 2.Choose i = 3, and nums becomes[4, 6, 2, 5].
            /// 3.Choose i = 1, and nums becomes[5, 5, 2, 5].
            /// The maximum integer of nums is 5.It can be shown that the maximum number cannot be less than 5.
            /// Therefore, we return 5.
            yield return new object[]
            {
                new[] { 3,7,1,6 },
                5
            };

            //// Explanation: It is optimal to leave nums as is, and since 10 is the maximum value, we return 10.
            yield return new object[]
            {
                new[] { 10, 1 },
                10
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
