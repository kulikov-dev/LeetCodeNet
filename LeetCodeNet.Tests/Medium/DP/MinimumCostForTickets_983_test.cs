using System.Collections;
using LeetCodeNet.Medium.DP;

namespace LeetCodeNet.Tests.Medium.DP
{
    public sealed class MinimumCostForTickets_983_test
    {
        [Theory, ClassData(typeof(MinimumCostForTicketsTestData))]
        public void CheckRecursive(int[] inputData1, int[] inputData2, int expected)
        {
            var solver = new MinimumCostForTickets_983();

            Assert.Equal(expected, solver.MincostTicketsRecursive(inputData1, inputData2));
        }

        [Theory, ClassData(typeof(MinimumCostForTicketsTestData))]
        public void CheckBottomUp(int[] inputData1, int[] inputData2, int expected)
        {
            var solver = new MinimumCostForTickets_983();

            Assert.Equal(expected, solver.MincostTicketsBottomUp(inputData1, inputData2));
        }
    }

    public sealed class MinimumCostForTicketsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: For example, here is one way to buy passes that lets you travel your travel plan:
            /// On day 1, you bought a 1 - day pass for costs[0] = $2, which covered day 1.
            /// On day 3, you bought a 7 - day pass for costs[1] = $7, which covered days 3, 4, ..., 9.
            /// On day 20, you bought a 1 - day pass for costs[0] = $2, which covered day 20.
            /// In total, you spent $11 and covered all the days of your travel.
            yield return new object[]
            {
                new[] { 1, 4, 6, 7, 8, 20 },
                new[] {2,7,15},
                11
            };

            yield return new object[]
            {
                new[] { 1,2,3,4,5,6,7,8,9,10,30,31 },
                new[] {2,7,15},
                17
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}