using System.Collections;
using LeetCodeNet.Easy.LeetMath;

namespace LeetCodeNet.Tests.Easy.LeetMath
{
    public sealed class SubtracttheProductandSumofDigitsofanInteger_1281_test
    {
        [Theory, ClassData(typeof(SubtracttheProductandSumofDigitsofanIntegerTestData))]
        public void CheckSimple(int inputData, int expected)
        {
            var solver = new SubtracttheProductandSumofDigitsofanInteger_1281();
            var result = solver.SubtractProductAndSum(inputData);
            Assert.Equal(expected, result);
        }
    }

    public sealed class SubtracttheProductandSumofDigitsofanIntegerTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Product of digits = 2 * 3 * 4 = 24
            /// Sum of digits = 2 + 3 + 4 = 9
            /// Result = 24 - 9 = 15
            yield return new object[]
            {
                234,
                15
            };

            //// Product of digits = 4 * 4 * 2 * 1 = 32
            /// Sum of digits = 4 + 4 + 2 + 1 = 11
            /// Result = 32 - 11 = 21
            yield return new object[]
            {
                4421,
                21
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
