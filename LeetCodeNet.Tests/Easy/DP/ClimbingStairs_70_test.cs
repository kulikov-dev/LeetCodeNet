using LeetCodeNet.Easy.DP;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.DP
{
    public sealed class ClimbingStairs_70_test
    {
        [Theory, ClassData(typeof(ClimbingStairsTestData))]
        public void CheckRecursive(int inputData, int expected)
        {
            var solver = new ClimbingStairs_70();

            Assert.Equal(expected, solver.ClimbStairsRecursive(inputData));
        }

        [Theory, ClassData(typeof(ClimbingStairsTestData))]
        public void CheckDP1(int inputData, int expected)
        {
            var solver = new ClimbingStairs_70();

            Assert.Equal(expected, solver.ClimbStairsDP1(inputData));
        }

        [Theory, ClassData(typeof(ClimbingStairsTestData))]
        public void CheckDP2(int inputData, int expected)
        {
            var solver = new ClimbingStairs_70();

            Assert.Equal(expected, solver.ClimbStairsDP2(inputData));
        }
    }

    public sealed class ClimbingStairsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: There are two ways to climb to the top.
            /// 1. 1 step + 1 step
            /// 2. 2 steps
            yield return new object[]
            {
                2,
                2
            };

            //// Explanation: There are three ways to climb to the top.
            /// 1. 1 step + 1 step + 1 step
            /// 2. 1 step + 2 steps
            /// 3. 2 steps + 1 step
            yield return new object[]
            {
                3,
                3
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}