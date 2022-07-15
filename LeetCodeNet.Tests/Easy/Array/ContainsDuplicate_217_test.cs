using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public class ContainsDuplicate_217_test
    {
        [Fact]
        public void CheckLinq()
        {
            var solver = new ContainsDuplicate_217();
            Assert.True(solver.ContainsDuplicateLinq(new int[] { 1, 2, 3, 1 }));
            Assert.False(solver.ContainsDuplicateLinq(new int[] { 1, 2, 3, 4 }));
            Assert.True(solver.ContainsDuplicateLinq(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }));
        }

        [Fact]
        public void CheckHash()
        {
            var solver = new ContainsDuplicate_217();
            Assert.True(solver.ContainsDuplicateHash(new int[] { 1, 2, 3, 1 }));
            Assert.False(solver.ContainsDuplicateHash(new int[] { 1, 2, 3, 4 }));
            Assert.True(solver.ContainsDuplicateHash(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }));
        }

        [Fact]
        public void CheckSorting()
        {
            var solver = new ContainsDuplicate_217();
            Assert.True(solver.ContainsDuplicateSorting(new int[] { 1, 2, 3, 1 }));
            Assert.False(solver.ContainsDuplicateSorting(new int[] { 1, 2, 3, 4 }));
            Assert.True(solver.ContainsDuplicateSorting(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }));
        }
    }
}
