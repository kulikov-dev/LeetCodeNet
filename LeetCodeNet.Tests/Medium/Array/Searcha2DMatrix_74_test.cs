using LeetCodeNet.Medium.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Medium.Array
{
    public sealed class Searcha2DMatrix_74_test
    {
        [Theory, ClassData(typeof(Searcha2DMatrixTestData))]
        public void Check(int[][] inputData1, int inputData2, bool expected)
        {
            var solver = new Searcha2DMatrix_74();

            Assert.Equal(expected, solver.SearchMatrix(inputData1, inputData2));
        }
    }

    public sealed class Searcha2DMatrixTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] {new[] { 1, 3, 5, 7 }, new [] { 10, 11, 16, 20 }, new[] { 23, 30, 34, 60 } },
                3,
                true
            };

            yield return new object[]
            {
                new[] {new[] { 1, 3, 5, 7 }, new [] { 10, 11, 16, 20 }, new[] { 23, 30, 34, 60 } },
                13,
                false
            };

            yield return new object[]
            {
                new[] {new[] { 1 } },
                1,
                true
            };

            yield return new object[]
            {
                new[] {new[] { 1, 1 } },
                2,
                false
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
