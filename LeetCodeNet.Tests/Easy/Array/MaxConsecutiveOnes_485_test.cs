using System.Collections;
using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class MaxConsecutiveOnes_485_test
    {
        [Theory, ClassData(typeof(MaxConsecutiveOnesTestData))]
        public void CheckSimple(int[] inputData, int expected)
        {
            var solver = new MaxConsecutiveOnes_485();
            var result = solver.FindMaxConsecutiveOnesSimple(inputData);

            Assert.Equal(expected, result);
        }

        [Theory, ClassData(typeof(MaxConsecutiveOnesTestData))]
        public void CheckShort(int[] inputData, int expected)
        {
            var solver = new MaxConsecutiveOnes_485();
            var result = solver.FindMaxConsecutiveOnesShort(inputData);

            Assert.Equal(expected, result);
        }
    }

    public sealed class MaxConsecutiveOnesTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new []{1,1,0,1,1,1},
                3
            };

            yield return new object[]
            {
                new []{1,0,1,1,0,1},
                2
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
