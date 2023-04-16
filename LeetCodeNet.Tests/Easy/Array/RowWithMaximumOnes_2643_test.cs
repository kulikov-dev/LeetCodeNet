using LeetCodeNet.Easy.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class RowWithMaximumOnes_2643_test
    {
        [Theory, ClassData(typeof(RowWithMaximumOnesTestData))]
        public void Check(int[][] inputData, int[] expected)
        {
            var solver = new RowWithMaximumOnes_2643();
            var result = solver.RowAndMaximumOnes(inputData);

            Assert.True(expected.SequenceEqual(result));
        }
    }

    public sealed class RowWithMaximumOnesTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                 new int[][]{new int[]{0,1}, new int[] {1,0}},
                 new int[] {0, 1}
            };

            yield return new object[]
            {
                new int[][]{new int[]{0, 0, 0}, new int[] {0, 1, 1}},
                new int[] {1 ,2}
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}