using LeetCodeNet.Easy.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class ReshapeTheMatrix_566_test
    {
        [Theory, ClassData(typeof(ReshapeTheMatrixTestData))]
        public void Check(int[][] inputData, int inputR, int inputC, int[][] expected)
        {
            var solver = new ReshapeTheMatrix_566();
            Assert.Equal(expected, solver.MatrixReshape(inputData, inputR, inputC));
        }
    }

    public sealed class ReshapeTheMatrixTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } },
                1,
                4,
                new int[][] { new int[] { 1, 2, 3, 4 } }
            };

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}