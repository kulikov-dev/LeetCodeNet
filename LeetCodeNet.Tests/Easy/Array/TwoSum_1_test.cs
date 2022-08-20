using LeetCodeNet.Easy.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class TwoSum_1_test
    {
        [Theory, ClassData(typeof(TwoSumTestData))]
        public void Check(int[] inputData, int target, int[] expected)
        {
            var solver = new TwoSum_1();
            Assert.Equal(expected, solver.TwoSum(inputData, target));
        }
    }

    public sealed class TwoSumTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
            yield return new object[]
            {
                new int[] { 2, 7, 11, 15 },
                9,
                new int[] { 0, 1 }
            };

            yield return new object[]
            {
                new int[] { 3, 2, 4 },
                6,
                new int[] { 1, 2 }
            };

            yield return new object[]
            {
                new int[] { 3, 3 },
                6,
                new int[] { 0, 1 }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}