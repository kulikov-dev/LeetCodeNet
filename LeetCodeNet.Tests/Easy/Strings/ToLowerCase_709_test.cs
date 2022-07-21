using LeetCodeNet.Easy.Strings;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Strings
{
    public class ToLowerCase_709_test
    {
        [Theory, ClassData(typeof(ToLowerCaseTestData))]
        public void CheckHash(string inputData, string expected)
        {
            var solver = new ToLowerCase_709();
            Assert.Equal(expected, solver.ToLowerCaseSimple(inputData));
        }

        [Theory, ClassData(typeof(ToLowerCaseTestData))]
        public void CheckSorting(string inputData, string expected)
        {
            var solver = new ToLowerCase_709();
            Assert.Equal(expected, solver.ToLowerCaseChar(inputData));
        }
    }

    public class ToLowerCaseTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "Hello",
                "hello"
            };

            yield return new object[]
            {
                "here",
                "here"
            };

            yield return new object[]
            {
                "LOVELY",
                "lovely"
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
