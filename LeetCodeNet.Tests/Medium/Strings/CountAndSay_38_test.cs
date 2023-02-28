using System.Collections;
using LeetCodeNet.Medium.Strings;

namespace LeetCodeNet.Tests.Medium.Strings
{
    public sealed class CountAndSay_38_test
    {
        [Theory, ClassData(typeof(CountAndSayTestData))]
        public void CheckRecursive(int inputData, string expected)
        {
            var solver = new CountAndSay_38();

            Assert.Equal(expected, solver.CountAndSayRecursive(inputData));
        }
    }

    public sealed class CountAndSayTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                1,
                "1"
            };

            yield return new object[]
            {
                4,
                "1211"
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
