using LeetCodeNet.Easy.DP;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.DP
{
    public sealed class MinCostClimbingStairs_746_test
    {
        [Theory, ClassData(typeof(MinCostClimbingStairsTestData))]
        public void CheckRecursive(int[] inputData, int expected)
        {
            var solver = new MinCostClimbingStairs_746();

            Assert.Equal(expected, solver.MinCostClimbingStairsRecursive(inputData));
        }

        [Theory, ClassData(typeof(MinCostClimbingStairsTestData))]
        public void CheckDp1(int[] inputData, int expected)
        {
            var solver = new MinCostClimbingStairs_746();

            Assert.Equal(expected, solver.MinCostClimbingStairsDp1(inputData));
        }

        [Theory, ClassData(typeof(MinCostClimbingStairsTestData))]
        public void CheckDp2(int[] inputData, int expected)
        {
            var solver = new MinCostClimbingStairs_746();

            Assert.Equal(expected, solver.MinCostClimbingStairsDp2(inputData));
        }
    }

    public sealed class MinCostClimbingStairsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
            yield return new object[]
            {
                new[] { 10,15,20 },
                15
            };

            yield return new object[]
            {
                new[] { 1,100,1,1,1,100,1,1,100,1 },
                6
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}