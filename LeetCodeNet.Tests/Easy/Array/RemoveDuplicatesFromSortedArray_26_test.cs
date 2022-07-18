using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public class RemoveDuplicatesFromSortedArray_26_test
    {
        [Fact]
        public void CheckMethod1()
        {
            var solver = new RemoveDuplicatesFromSortedArray_26();

            var sourceArray = new int[] { 1, 1, 2 };
            var result = solver.RemoveDuplicates(sourceArray);
            Assert.Equal(2, result);
            Assert.Equal(new int[] { 1, 2, -101 }, sourceArray);

            sourceArray = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            result = solver.RemoveDuplicates(sourceArray);
            Assert.Equal(5, result);
            Assert.Equal(new int[] { 0, 1, 2, 3, 4, -101, -101, -101, -101, -101 }, sourceArray);

            sourceArray = new int[] { 1 };
            result = solver.RemoveDuplicates(sourceArray);
            Assert.Equal(1, result);
            Assert.Equal(new int[] { 1 }, sourceArray);
        }
    }
}
