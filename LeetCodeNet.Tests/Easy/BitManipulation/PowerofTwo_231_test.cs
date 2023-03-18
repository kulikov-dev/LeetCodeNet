using System.Collections;
using LeetCodeNet.Easy.BitManipulation;

namespace LeetCodeNet.Tests.Easy.BitManipulation
{
    public sealed class PowerofTwo_231_test
    {
        [Theory, ClassData(typeof(PowerofTwoTestData))]
        public void CheckMath(int inputData, bool expected)
        {
            var solver = new PowerofTwo_231();
            var result = solver.IsPowerOfTwoMath(inputData);

            Assert.Equal(expected, result);
        }

        [Theory, ClassData(typeof(PowerofTwoTestData))]
        public void CheckBit(int inputData, bool expected)
        {
            var solver = new PowerofTwo_231();
            var result = solver.IsPowerOfTwoBit(inputData);

            Assert.Equal(expected, result);
        }
    }

    public sealed class PowerofTwoTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                1,
                true
            };

            yield return new object[]
            {
                16,
                true
            };

            yield return new object[]
            {
                3,
                false
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
