using LeetCodeNet.Easy.Design;

namespace LeetCodeNet.Tests.Easy.Design
{
    public sealed class MinStack_155_test
    {
        [Fact]
        public void Check()
        {
            var solver = new MinStack();

            solver.Push(-2);
            solver.Push(0);
            solver.Push(-3);

            Assert.Equal(solver.GetMin(), -3);
            solver.Pop();
            Assert.Equal(solver.Top(), 0);
            Assert.Equal(solver.GetMin(), -2);
        }
    }
}