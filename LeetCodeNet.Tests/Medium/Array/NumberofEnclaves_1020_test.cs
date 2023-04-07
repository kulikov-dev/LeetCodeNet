using LeetCodeNet.Medium.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Medium.Array
{
    public sealed class NumberofEnclaves_1020_test
    {
        [Theory, ClassData(typeof(NumberofEnclavesTestData))]
        public void Check(int[][] inputData, int expected)
        {
            var solver = new NumberofEnclaves_1020();

            Assert.Equal(expected, solver.NumEnclaves(inputData));
        }
    }

    public sealed class NumberofEnclavesTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: There are three 1s that are enclosed by 0s, and one 1 that is not enclosed because its on the boundary.
            yield return new object[]
            {
                new[] { new[] { 0, 0, 0, 0 }, new[] { 1, 0, 1, 0 }, new[] { 0, 1, 1, 0 }, new int[] {0, 0, 0, 0} },
               3
            };

            yield return new object[]
            {
                new[] { new[] { 0, 1, 1, 0 }, new[] { 0, 0, 1, 0 }, new[] { 0, 0, 1, 0 }, new int[] {0, 0, 0, 0} },
                0
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
