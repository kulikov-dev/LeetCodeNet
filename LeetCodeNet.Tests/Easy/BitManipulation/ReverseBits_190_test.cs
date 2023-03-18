using System.Collections;
using LeetCodeNet.Easy.BitManipulation;

namespace LeetCodeNet.Tests.Easy.BitManipulation
{
    public sealed class ReverseBits_190_test
    {
        [Theory, ClassData(typeof(ReverseBitsTestData))]
        public void CheckBit(uint inputData, uint expected)
        {
            var solver = new ReverseBits_190();
            var result = solver.reverseBits(inputData);

            Assert.Equal(expected, result);
        }
    }

    public sealed class ReverseBitsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                43261596,
                964176192
            };

            yield return new object[]
            {
                4294967293,
                3221225471
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
