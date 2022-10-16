using System.Collections;
using LeetCodeNet.Easy.BitManipulation;

namespace LeetCodeNet.Tests.Easy.BitManipulation
{
    public sealed class SingleNumber_136_test
    {
        [Theory, ClassData(typeof(SingleNumberTestData))]
        public void CheckBit(int[] inputData, int expected)
        {
            var solver = new SingleNumber_136();
            var result = solver.SingleNumber(inputData);
            Assert.Equal(expected, result);
        }
    }

    public sealed class SingleNumberTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new int[]{2,2,1},
                1
            };

            yield return new object[]
            {
                new int[] {4,1,2,1,2},
                4
            };

            yield return new object[]
            {
                new int[] {1},
                1
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
