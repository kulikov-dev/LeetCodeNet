using System.Collections;
using LeetCodeNet.Medium.LeetMath;

namespace LeetCodeNet.Tests.Medium.LeetMath
{
    public sealed class SumofSquareNumbers_633_test
    {
        [Theory, ClassData(typeof(SumofSquareNumbersTestData))]
        public void CheckPointers(int inputData, bool expected)
        {
            var solver = new SumofSquareNumbers_633();
            var result = solver.JudgeSquareSumPointers(inputData);

            Assert.Equal(expected, result);
        }

        [Theory, ClassData(typeof(SumofSquareNumbersTestData))]
        public void CheckHash(int inputData, bool expected)
        {
            var solver = new SumofSquareNumbers_633();
            var result = solver.JudgeSquareSumHash(inputData);

            Assert.Equal(expected, result);
        }
    }

    public sealed class SumofSquareNumbersTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                5,
                true
            };

            yield return new object[]
            {
                3,
                false
            };

            yield return new object[]
            {
                2,
                true
            };

            yield return new object[]
            {
                1,
                true
            };

            yield return new object[]
            {
                1000000,
                true
            };
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
