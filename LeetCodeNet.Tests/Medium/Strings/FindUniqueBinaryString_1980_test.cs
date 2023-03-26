using System.Collections;
using LeetCodeNet.Medium.Strings;

namespace LeetCodeNet.Tests.Medium.Strings
{
    public sealed class FindUniqueBinaryString_1980_test
    {
        [Theory, ClassData(typeof(FindUniqueBinaryStringTestData))]
        public void CheckBruteForce(string[] inputData, List<string> expected)
        {
            var solver = new FindUniqueBinaryString_1980();

            Assert.Contains(solver.FindDifferentBinaryStringBruteForce(inputData), expected);
        }

        [Theory, ClassData(typeof(FindUniqueBinaryStringTestData))]
        public void CheckCantor(string[] inputData, List<string> expected)
        {
            var solver = new FindUniqueBinaryString_1980();

            Assert.Contains(solver.FindDifferentBinaryStringCantor(inputData), expected);
        }
    }

    public sealed class FindUniqueBinaryStringTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] {"01","10"},
                new List<string> {"00", "11"}
            };

            yield return new object[]
            {
                new[] {"00","01"},
                new List<string> {"10", "11"}
            };

            yield return new object[]
            {
                new[] {"111","011","001"},
                new List<string> { "000", "010", "100", "101", "110"}
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
