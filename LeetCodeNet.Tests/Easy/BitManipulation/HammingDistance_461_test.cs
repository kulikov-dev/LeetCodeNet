using System.Collections;
using LeetCodeNet.Easy.BitManipulation;

namespace LeetCodeNet.Tests.Easy.BitManipulation
{
    public sealed class HammingDistance_461_test
    {
        [Theory, ClassData(typeof(HammingDistanceTestData))]
        public void Check(int inputData1, int inputData2, int expected)
        {
            var solver = new HammingDistance_461();
            var result = solver.HammingDistance(inputData1, inputData2);

            Assert.Equal(expected, result);
        }
    }

    public sealed class HammingDistanceTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation:
            /// 1(0 0 0 1)
            /// 4(0 1 0 0)
            ///     ↑   ↑
            /// The above arrows point to positions where the corresponding bits are different.
            yield return new object[]
            {
                1,
                4,
                2
            };

            yield return new object[]
            {
                3,
                1,
                1
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
