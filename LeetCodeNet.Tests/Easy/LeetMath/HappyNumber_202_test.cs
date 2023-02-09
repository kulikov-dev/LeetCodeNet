using System.Collections;
using LeetCodeNet.Easy.LeetMath;

namespace LeetCodeNet.Tests.Easy.LeetMath
{
    public sealed class HappyNumber_202_test
    {
        [Theory, ClassData(typeof(HappyNumberTestData))]
        public void CheckSimple(int inputData, bool expected)
        {
            var solver = new HappyNumber_202();
            var result = solver.IsHappy(inputData);

            Assert.Equal(expected, result);
        }
    }

    public sealed class HappyNumberTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation:
            /// 12 + 92 = 82
            /// 82 + 22 = 68
            /// 62 + 82 = 100
            /// 12 + 02 + 02 = 1
            yield return new object[]
            {
                19,
                true
            };

            yield return new object[]
            {
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
