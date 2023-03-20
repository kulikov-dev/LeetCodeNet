using System.Collections;
using LeetCodeNet.Easy.LeetMath;

namespace LeetCodeNet.Tests.Easy.LeetMath
{
    public sealed class CheckIfItIsaStraightLine_1232_test
    {
        [Theory, ClassData(typeof(CheckIfItIsaStraightLineTestData))]
        public void CheckSimple(int[][] inputData, bool expected)
        {
            var solver = new CheckIfItIsaStraightLine_1232();
            var result = solver.CheckStraightLine(inputData);

            Assert.Equal(expected, result);
        }
    }

    public sealed class CheckIfItIsaStraightLineTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] { new[] { 1,2 }, new[] {2,3 }, new[] { 3,4 } , new[] { 4,5 }, new[] { 5,6 }, new[] { 6,7 }},
                true
            };

            yield return new object[]
            {
                new[] { new[] { 1,1 }, new[] {2,2 }, new[] { 3,4 } , new[] { 4,5 }, new[] { 5,6 }, new[] { 7,7 }},
                false
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
