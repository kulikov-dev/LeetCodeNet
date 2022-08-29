using System.Collections;
using LeetCodeNet.Easy.BitManipulation;

namespace LeetCodeNet.Tests.Easy.BitManipulation
{
    public sealed class Numberof1Bits_191_test
    {
        [Theory, ClassData(typeof(Numberof1BitsTestData))]
        public void CheckShift(uint inputData, int expected)
        {
            var solver = new Numberof1Bits_191();
            var result = solver.HammingWeightShift(inputData);
            Assert.Equal(expected, result);
        }

        [Theory, ClassData(typeof(Numberof1BitsTestData))]
        public void CheckBit(uint inputData, int expected)
        {
            var solver = new Numberof1Bits_191();
            var result = solver.HammingWeightBit(inputData);
            Assert.Equal(expected, result);
        }
    }

    public sealed class Numberof1BitsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: The input binary string 00000000000000000000000000001011 has a total of three '1' bits.
            yield return new object[]
            {
                11,
                3
            };

            yield return new object[]
            {
                64,
                1
            };

            yield return new object[]
            {
                4294967293,
                31
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}