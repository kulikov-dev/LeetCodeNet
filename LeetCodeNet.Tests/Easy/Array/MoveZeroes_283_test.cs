using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public class MoveZeroes_283_test
    {
        [Fact]
        public void Check()
        {
            var solver = new MoveZeroes_283();

            //// Note that you must do this in-place without making a copy of the array.
            var source = new int[] { 0, 1, 0, 3, 12 };
            solver.MoveZeroes(source);
            Assert.Equal(new int[] { 1, 3, 12, 0, 0 }, source);

            source = new int[] { 1 };
            solver.MoveZeroes(source);
            Assert.Equal(new int[] { 1 }, source);
        }

        [Fact]
        public void CheckOpimal()
        {
            var solver = new MoveZeroes_283();

            //// Note that you must do this in-place without making a copy of the array.
            var source = new int[] { 0, 1, 0, 3, 12 };
            solver.MoveZeroesOptimization(source);
            Assert.Equal(new int[] { 1, 3, 12, 0, 0 }, source);

            source = new int[] { 1 };
            solver.MoveZeroesOptimization(source);
            Assert.Equal(new int[] { 1 }, source);
        }
    }
}
