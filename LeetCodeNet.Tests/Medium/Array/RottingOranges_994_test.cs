using LeetCodeNet.Medium.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Medium.Array
{
    public sealed class RottingOranges_994_test
    {
        [Theory, ClassData(typeof(RottingOranges_994TestData))]
        public void Check(int[][] inputData, int expected)
        {
            var solver = new RottingOranges_994();

            Assert.Equal(expected, solver.OrangesRotting(inputData));
        }
    }

    public sealed class RottingOranges_994TestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: [4,-1,2,1] has the largest sum = 6.
            yield return new object[]
            {
                new[] { new[] { 2, 1, 1 }, new[] { 1, 1, 0 }, new[] { 0, 1, 1 } },
                4
            };

            yield return new object[]
            {
                new[] { new[] { 0, 2 } },
                0
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
