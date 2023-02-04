using System.Collections;
using LeetCodeNet.Easy.LeetMath;

namespace LeetCodeNet.Tests.Easy.LeetMath
{
    public sealed class RomanToInteger_13_test
    {
        [Theory, ClassData(typeof(RomanToIntegerTestData))]
        public void CheckSimple(string inputData, int expected)
        {
            var solver = new RomanToInteger_13();
            var result = solver.RomanToInt(inputData);

            Assert.Equal(expected, result);
        }
    }

    public sealed class RomanToIntegerTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "III",
                3
            };

            yield return new object[]
            {
                "IV",
                4
            };

            //// Explanation: L = 50, V= 5, III = 3.
            yield return new object[]
            {
                "LVIII",
                58
            };

            //// Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
            yield return new object[]
            {
                "MCMXCIV",
                1994
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
