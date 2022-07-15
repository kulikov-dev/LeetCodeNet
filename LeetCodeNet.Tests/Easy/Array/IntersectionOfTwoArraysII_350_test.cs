using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public class IntersectionOfTwoArraysII_350_test
    {
        [Fact]
        public void CheckHash()
        {
            var solver = new IntersectionOfTwoArraysII_350();
            Assert.Equal(new int[] { 2 }, solver.IntersectHash(new int[] { 1, 2, 2, 1 }, new int[] { 2 }));
            Assert.Equal(new int[] { 2, 2 }, solver.IntersectHash(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 }));
            Assert.Equal(new int[] { 9, 4 }, solver.IntersectHash(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 }));
        }

        [Fact]
        public void CheckSorting()
        {
            var solver = new IntersectionOfTwoArraysII_350();
            Assert.Equal(new int[] { 2 }, solver.IntersectSorted(new int[] { 1, 2, 2, 1 }, new int[] { 2 }));
            Assert.Equal(new int[] { 2, 2 }, solver.IntersectSorted(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 }));
            Assert.Equal(new int[] { 4, 9 }, solver.IntersectSorted(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 }));
        }
    }
}
