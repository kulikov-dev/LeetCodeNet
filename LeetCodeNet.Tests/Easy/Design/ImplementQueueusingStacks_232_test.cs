using LeetCodeNet.Easy.Design;

namespace LeetCodeNet.Tests.Easy.Design
{
    public sealed class ImplementQueueusingStacks_232_test
    {
        [Fact]
        public void Check()
        {
            var solver = new MyStack();

            solver.Push(1);
            solver.Push(2);
            Assert.Equal(solver.Top(), 2);
            Assert.Equal(solver.Pop(), 2);
            Assert.False(solver.Empty());
        }
    }
}