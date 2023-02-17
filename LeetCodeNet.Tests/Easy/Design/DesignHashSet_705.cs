using LeetCodeNet.Easy.Design;

namespace LeetCodeNet.Tests.Easy.Design
{
    public sealed class DesignHashSet_705
    {
        [Fact]
        public void CheckSimple()
        {
            var solver = new MyHashSet_Easy();

            solver.Add(1);
            solver.Add(2);
            Assert.True(solver.Contains(1));
            Assert.False(solver.Contains(3));
            solver.Remove(2);
            Assert.False(solver.Contains(2));
            solver.Add(1000000);
            Assert.True(solver.Contains(1000000));
        }

        [Fact]
        public void CheckOptimal()
        {
            var solver = new MyHashSet_Optimal();

            solver.Add(1);
            solver.Add(2);
            Assert.True(solver.Contains(1));
            Assert.False(solver.Contains(3));
            solver.Remove(2);
            Assert.False(solver.Contains(2));
            solver.Add(1000000);
            Assert.True(solver.Contains(1000000));
        }
    }
}