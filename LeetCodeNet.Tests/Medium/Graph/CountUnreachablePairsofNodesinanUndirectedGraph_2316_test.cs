using System.Collections;
using LeetCodeNet.Medium.Graph;

namespace LeetCodeNet.Tests.Medium.Graph
{
    public sealed class CountUnreachablePairsofNodesinanUndirectedGraph_2316_test
    {
        [Theory, ClassData(typeof(CountUnreachablePairsofNodesinanUndirectedGraphTestData))]
        public void Check(int[][] inputData2, int inputData1, int expected)
        {
            var solver = new CountUnreachablePairsofNodesinanUndirectedGraph_2316();

            Assert.Equal(expected, solver.CountPairs(inputData1, inputData2));
        }
    }

    public sealed class CountUnreachablePairsofNodesinanUndirectedGraphTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 0, 2 } },
                3,
                0
            };

            //// Explanation: There are 14 pairs of nodes that are unreachable from each other
            /// [[0,1],[0,3],[0,6],[1,2],[1,3],[1,4],[1,5],[2,3],[2,6],[3,4],[3,5],[3,6],[4,6],[5,6]].
            /// Therefore, we return 14.
            yield return new object[]
            {
                new[] { new[] { 0, 2 }, new[] { 0, 5 }, new[] {2, 4}, new[] { 1, 6 }, new[] { 5, 4 }},
                7,
                14
            };

            yield return new object[]
            {
                new[] { new[] { 5,0}, new[] { 1, 0}, new[] { 10,7}, new[] { 9,8}, new[] { 7,2}, new[] { 1,3}, new[] { 0,2}, new[] { 8,5}, new[] { 4,6}, new[] { 4,2}},
                11,
                0
            };

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}