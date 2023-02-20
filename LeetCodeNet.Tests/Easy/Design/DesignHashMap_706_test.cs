using LeetCodeNet.Easy.Design;

namespace LeetCodeNet.Tests.Easy.Design
{
    public sealed class DesignHashMap_706_test
    {
        [Fact]
        public void Check()
        {
            var solver = new MyHashMap();

            solver.Put(1, 1);
            solver.Put(2, 2);
            Assert.Equal(1, solver.Get(1));
            Assert.Equal(-1, solver.Get(3));
            solver.Put(2,1);
            Assert.Equal(1, solver.Get(2));
            solver.Remove(2);
            Assert.Equal(-1, solver.Get(2));
        }
    }
}