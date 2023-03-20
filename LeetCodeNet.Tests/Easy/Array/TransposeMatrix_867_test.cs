using LeetCodeNet.Easy.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class TransposeMatrix_867_test
    {
        [Theory, ClassData(typeof(TransposeMatrixTestData))]
        public void Check(int[][] inputData, int[][] expected)
        {
            var solver = new TransposeMatrix_867();

            Assert.Equal(expected, solver.Transpose(inputData));
        }

        [Fact]
        public void CheckInPlace()
        {
            var solver = new TransposeMatrix_867();

            Assert.Equal(new[] { new[] { 1, 4, 7 }, new[] { 2, 5, 8 }, new[] { 3, 6, 9 } }, solver.TransposeInPlace(new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } }));
        }
    }

    public sealed class TransposeMatrixTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } },
                new[] { new[] { 1, 4, 7 }, new[] { 2, 5, 8 }, new[] { 3, 6, 9 } }
            };

            yield return new object[]
            {
                new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 } },
                new[] { new[] { 1, 4 }, new[] { 2, 5 }, new[] { 3, 6 } }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}