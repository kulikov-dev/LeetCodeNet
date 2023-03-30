using System.Collections;
using LeetCodeNet.Medium.Array;

namespace LeetCodeNet.Tests.Medium.Array
{
    public sealed class MaxConsecutiveOnesIII_1004_test
    {
        [Theory, ClassData(typeof(MaxConsecutiveOnesIIITestData))]
        public void CheckSimple(int[] inputData1, int inputData2, int expected)
        {
            var solver = new MaxConsecutiveOnesIII_1004();
            var result = solver.LongestOnesSimple(inputData1, inputData2);

            Assert.Equal(expected, result);
        }

        [Theory, ClassData(typeof(MaxConsecutiveOnesIIITestData))]
        public void CheckOptimal(int[] inputData1, int inputData2, int expected)
        {
            var solver = new MaxConsecutiveOnesIII_1004();
            var result = solver.LongestOnesOptimal(inputData1, inputData2);

            Assert.Equal(expected, result);
        }
    }

    public sealed class MaxConsecutiveOnesIIITestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new []{1,1,1,0,0,0,1,1,1,1,0},
                2,
                6
            };

            yield return new object[]
            {
                new []{0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1},
                3,
                10
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
