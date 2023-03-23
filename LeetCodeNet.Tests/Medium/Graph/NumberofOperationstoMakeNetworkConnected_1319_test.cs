using System.Collections;
using LeetCodeNet.Medium.Graph;

namespace LeetCodeNet.Tests.Medium.Graph
{
    public sealed class NumberofOperationstoMakeNetworkConnected_1319_test
    {
        [Theory, ClassData(typeof(NumberofOperationstoMakeNetworkConnectedTestData))]
        public void Check(int[][] inputData2, int inputData1, int expected)
        {
            var solver = new NumberofOperationstoMakeNetworkConnected_1319();

            Assert.Equal(expected, solver.MakeConnected(inputData1, inputData2));
        }
    }

    public sealed class NumberofOperationstoMakeNetworkConnectedTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: Remove cable between computer 1 and 2 and place between computers 1 and 3.
            yield return new object[]
            {
                new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 0, 2 } },
                4,
                1
            };

            yield return new object[]
            {
                new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] {0, 3}, new[] { 1, 2 }, new[] { 1, 3 }},
                6,
                2
            };

            yield return new object[]
            {
                new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 }, new[] { 1, 2 } },
                6,
                -1
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}