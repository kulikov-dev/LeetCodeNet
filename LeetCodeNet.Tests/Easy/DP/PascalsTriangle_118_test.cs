using LeetCodeNet.Easy.DP;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.DP
{
    public sealed class PascalsTriangle_118_test
    {
        [Theory, ClassData(typeof(PascalsTriangleTestData))]
        public void CheckLinq(int inputData, int[][] expected)
        {
            var solver = new PascalsTriangle_118();
            Assert.Equal(expected, solver.Generate(inputData));
        }
    }

    public sealed class PascalsTriangleTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                5,
                new int[][] { new int[] { 1 }, new int[] { 1, 1 }, new int[] { 1, 2, 1 }, new int[] { 1, 3, 3, 1 }, new int[] { 1, 4, 6, 4, 1 } }
            };

            yield return new object[]
            {
               1,
                new int[][] { new int[] { 1 } }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
