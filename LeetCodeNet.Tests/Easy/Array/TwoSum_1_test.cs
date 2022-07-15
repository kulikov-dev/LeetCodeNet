using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public class TwoSum_1_test
    {
        [Fact]
        public void CheckMethod1()
        {
            var solver = new TwoSum_1();
            var result = solver.TwoSum(new int[] { 2, 7, 11, 15 }, 9);

            //// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
            Assert.Equal(result, new int[] { 0, 1 });

            result = solver.TwoSum(new int[] { 3, 2, 4 }, 6);
            Assert.Equal(result, new int[] { 1, 2 });

            result = solver.TwoSum(new int[] { 3, 3 }, 6);
            Assert.Equal(result, new int[] { 0, 1 });
        }
    }
}