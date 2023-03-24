using System.Collections;
using LeetCodeNet.Medium.Graph;

namespace LeetCodeNet.Tests.Medium.Graph
{
    public sealed class ReorderRoutestoMakeAllPathsLeadtotheCityZero_1466_test
    {
        [Theory, ClassData(typeof(ReorderRoutestoMakeAllPathsLeadtotheCityZeroTestData))]
        public void Check(int[][] inputData2, int inputData1, int expected)
        {
            var solver = new ReorderRoutestoMakeAllPathsLeadtotheCityZero_1466();

            Assert.Equal(expected, solver.MinReorder(inputData1, inputData2));
        }
    }

    public sealed class ReorderRoutestoMakeAllPathsLeadtotheCityZeroTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] { new[] { 0, 1 }, new[] { 1, 3 }, new[] { 2, 3 }, new[] { 4, 0 }, new[] { 4,5 } },
                6,
                3
            };

            yield return new object[]
            {
                new[] { new[] { 1, 0 }, new[] { 1, 2}, new[] { 3, 2 }, new[] { 3, 4 }},
                5,
                2
            };

            yield return new object[]
            {
                new[] { new[] { 1, 0 }, new[] { 2, 0} },
                3,
                0
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}