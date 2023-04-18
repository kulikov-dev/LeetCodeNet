using System.Collections;
using LeetCodeNet.Easy.Strings;

namespace LeetCodeNet.Tests.Easy.Strings
{
    public sealed class BackspaceStringCompare_844_test
    {
        [Theory, ClassData(typeof(BackspaceStringCompareTestData))]
        public void CheckStack(string inputData1, string inputData2, bool expected)
        {
            var solver = new BackspaceStringCompare_844();

            Assert.Equal(expected, solver.BackspaceCompareStack(inputData1, inputData2));
        }

        [Theory, ClassData(typeof(BackspaceStringCompareTestData))]
        public void CheckStringBuilder(string inputData1, string inputData2, bool expected)
        {
            var solver = new BackspaceStringCompare_844();

            Assert.Equal(expected, solver.BackspaceCompareStringBuilder(inputData1, inputData2));
        }
    }

    public sealed class BackspaceStringCompareTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: Both s and t become "ac".
            yield return new object[]
            {
                "ab#c",
                "ad#c",
                true
            };

            //// Explanation: Both s and t become "".
            yield return new object[]
            {
                "ab##",
                "c#d#",
                true
            };

            yield return new object[]
            {
                "a#c",
                "b",
                false
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
