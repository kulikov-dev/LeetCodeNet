using LeetCodeNet.Easy.Design;

namespace LeetCodeNet.Tests.Easy.Design
{
    public sealed class RangeSumQuery_Immutable_303_test
    {
        [Fact]
        public void Check()
        {
            var solver = new NumArray(new[] { -2, 0, 3, -5, 2, -1 });
            Assert.Equal(solver.SumRange(0, 2), 1);
            Assert.Equal(solver.SumRange(2, 5), -1);
            Assert.Equal(solver.SumRange(0, 5), -3);
        }
    }
}