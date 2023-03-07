using LeetCodeNet.Medium.Array;
using LeetCodeNet.Tests.Easy.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Medium.Array
{
    public sealed class TwoSumII_167_test
    {
        [Theory, ClassData(typeof(TwoSumIITestData))]
        public void Check(int[] inputData1, int inputData2, int[] expected)
        {
            var solver = new TwoSumII_167();

            Assert.Equal(expected, solver.TwoSum(inputData1, inputData2));
        }
    }

    public sealed class TwoSumIITestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: The sum of 2 and 7 is 9. Therefore, index1 = 1, index2 = 2. We return [1, 2].
            yield return new object[]
            {
                new int[] {2,7,11,15},
                9,
                new int[] {1,2}
            };

            //// Explanation: The sum of 2 and 4 is 6. Therefore index1 = 1, index2 = 3. We return [1, 3].
            yield return new object[]
            {
                new int[] {2,3,4},
                6,
                new int[] {1,3}
            };

            //// Explanation: The sum of -1 and 0 is -1. Therefore index1 = 1, index2 = 2. We return [1, 2].
            yield return new object[]
            {
                new int[] {-1, 0},
                -1,
                new int[] {1,2}
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
