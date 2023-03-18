using LeetCodeNet.Easy.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class MoveZeroes_283_test
    {
        [Theory, ClassData(typeof(MoveZeroesTestData))]
        public void Check(int[] inputData, int[] expected)
        {
            var solver = new MoveZeroes_283();

            solver.MoveZeroesOptimization(inputData);
            Assert.Equal(expected, inputData);
        }

        [Theory, ClassData(typeof(MoveZeroesTestData))]
        public void CheckOpimal(int[] inputData, int[] expected)
        {
            var solver = new MoveZeroes_283();

            solver.MoveZeroesOptimization(inputData);
            Assert.Equal(expected, inputData);
        }
    }

    public sealed class MoveZeroesTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Note that you must do this in-place without making a copy of the array.
            yield return new object[]
            {
                new int[] { 0, 1, 0, 3, 12 },
                new int[] { 1, 3, 12, 0, 0 }
            };

            yield return new object[]
            {
                new int[] { 1 },
                new int[] { 1 }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
