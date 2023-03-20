using LeetCodeNet.Easy.DP;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.DP
{
    public sealed class CanPlaceFlowers_605_test
    {
        [Theory, ClassData(typeof(CanPlaceFlowersTestData))]
        public void CheckRecursive(int[] inputData1, int inputData2, bool expected)
        {
            var solver = new CanPlaceFlowers_605();

            Assert.Equal(expected, solver.CanPlaceFlowersRecursive(inputData1, inputData2));
        }

        [Theory, ClassData(typeof(CanPlaceFlowersTestData))]
        public void CheckBottomUp(int[] inputData1, int inputData2, bool expected)
        {
            var solver = new CanPlaceFlowers_605();

            Assert.Equal(expected, solver.CanPlaceFlowersBottomUp(inputData1, inputData2));
        }

        [Theory, ClassData(typeof(CanPlaceFlowersTestData))]
        public void CheckBottomUpOptimized(int[] inputData1, int inputData2, bool expected)
        {
            var solver = new CanPlaceFlowers_605();

            Assert.Equal(expected, solver.CanPlaceFlowersBottomUpOptimized(inputData1, inputData2));
        }
    }

    public sealed class CanPlaceFlowersTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] { 1,0,0,0,1 },
                1,
                true
            };

            yield return new object[]
            {
                new[] {1,0,0,0,1},
                2,
                false
            };

            yield return new object[]
            {
                new[] {1,0,0,0,1,0,0},
                2,
                true
            };

            yield return new object[]
            {
                new[] {1,0,0,0,0, 1},
                2,
                false
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}