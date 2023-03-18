using LeetCodeNet.Easy.Design;

namespace LeetCodeNet.Tests.Easy.Design
{
    public sealed class ImplementStackusingQueues_225_test
    {
        [Fact]
        public void Check()
        {
            var solver = new MyQueue();

            solver.Push(1);
            solver.Push(2);
            Assert.Equal(solver.Peek(), 1);
            Assert.Equal(solver.Pop(), 1);
            Assert.False(solver.Empty());
        }
    }
}