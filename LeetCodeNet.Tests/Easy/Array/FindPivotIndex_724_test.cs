using System.Collections;
using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class FindPivotIndex_724_test
    {
        [Theory, ClassData(typeof(FindPivotIndexTestData))]
        public void CheckSimple(int[] inputData, int expected)
        {
            var solver = new FindPivotIndex_724();

            Assert.Equal(expected, solver.PivotIndexSimple(inputData));
        }

        [Theory, ClassData(typeof(FindPivotIndexTestData))]
        public void CheckOptimized(int[] inputData, int expected)
        {
            var solver = new FindPivotIndex_724();

            Assert.Equal(expected, solver.PivotIndexOptimizied(inputData));
        }
    }

    public sealed class FindPivotIndexTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation:
            /// The pivot index is 3.
            /// Left sum = nums[0] + nums[1] + nums[2] = 1 + 7 + 3 = 11
            /// Right sum = nums[4] + nums[5] = 5 + 6 = 11
            yield return new object[]
            {
                new []{1,7,3,6,5,6},
                3
            };

            yield return new object[]
            {
                new []{ 1,2,3 },
                -1
            };

            //// Explanation:
            /// The pivot index is 0.
            /// Left sum = 0(no elements to the left of index 0)
            /// Right sum = nums[1] + nums[2] = 1 + -1 = 0
            yield return new object[]
            {
                new []{ 2,1,-1 },
                0
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
