using LeetCodeNet.Medium.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Medium.Array
{
    public sealed class SumofMatrixAfterQueries_2718_test
    {
        [Theory, ClassData(typeof(SumofMatrixAfterQueriesTestData))]
        public void CheckTwoPass(int input1, int[][] input2, long expected)
        {
            var solver = new SumofMatrixAfterQueries_2718();

            Assert.Equal(expected, solver.MatrixSumQueries(input1, input2));
        }
    }

    public sealed class SumofMatrixAfterQueriesTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                3,
                new [] {new[] { 0,0,1 }, new [] {1,2,2 }, new[] { 0,2,3}, new[] { 1,0,4} },
                23
            };

            yield return new object[]
            {
                3,
                new [] {new[] { 0, 0, 4 }, new [] { 0,1,2 }, new[] {1,0,1}, new[] { 0,2,3}, new[] { 1,2,1} },
                17
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
