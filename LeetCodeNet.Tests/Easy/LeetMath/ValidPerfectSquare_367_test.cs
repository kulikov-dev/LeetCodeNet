using LeetCodeNet.Easy.LeetMath;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.LeetMath
{
    public sealed class ValidPerfectSquare_367_test
    {
        [Theory, ClassData(typeof(ValidPerfectSquareTestData))]
        public void CheckSimple(int inputData, bool expected)
        {
            var solver = new ValidPerfectSquare_367();

            Assert.Equal(expected, solver.IsPerfectSquare(inputData));
        }
    }

    public sealed class ValidPerfectSquareTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
               16,
               true
            };

            yield return new object[]
            {
               14,
               false
            };

            yield return new object[]
            {
                808201,
               true
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}