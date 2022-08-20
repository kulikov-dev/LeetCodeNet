using LeetCodeNet.Easy.Strings;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Strings
{
    public sealed class ImplementstrStr_28_test
    {
        [Theory, ClassData(typeof(ImplementstrStrTestData))]
        public void CheckBruteForceTwoPass(string inputData1, string inputData2, int expected)
        {
            var solver = new ImplementstrStr_28();
            Assert.Equal(expected, solver.StrStrBruteForceTwoPass(inputData1, inputData2));
        }

        [Theory, ClassData(typeof(ImplementstrStrTestData))]
        public void CheckCheating(string inputData1, string inputData2, int expected)
        {
            var solver = new ImplementstrStr_28();
            Assert.Equal(expected, solver.StrStrCheating(inputData1, inputData2));
        }

        [Theory, ClassData(typeof(ImplementstrStrTestData))]
        public void CheckKMP(string inputData1, string inputData2, int expected)
        {
            var solver = new ImplementstrStr_28();
            Assert.Equal(expected, solver.StrStrKMP(inputData1, inputData2));
        }
    }

    public sealed class ImplementstrStrTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
               "hello",
               "ll",
               2
            };

            yield return new object[]
            {
                "aaaaa",
                "bba",
                -1
            };

            yield return new object[]
            {
                "aaa",
                "aaaa",
                -1
            };

            yield return new object[]
{
                "mississippi",
                "issip",
                4
};
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}