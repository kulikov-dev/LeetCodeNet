using LeetCodeNet.Easy.Strings;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeNet.Tests.Easy.Strings
{
    public class FindtheDifference_389_test
    {
        [Theory, ClassData(typeof(FindtheDifferenceTestData))]
        public void CheckSort(string inputData1, string inputData2, char expected)
        {
            var solver = new FindtheDifference_389();
            Assert.Equal(expected, solver.FindTheDifferenceSort(inputData1, inputData2));
        }

        [Theory, ClassData(typeof(FindtheDifferenceTestData))]
        public void CheckHash(string inputData1, string inputData2, char expected)
        {
            var solver = new FindtheDifference_389();
            Assert.Equal(expected, solver.FindTheDifferenceHash(inputData1, inputData2));
        }

        [Theory, ClassData(typeof(FindtheDifferenceTestData))]
        public void CheckMath(string inputData1, string inputData2, char expected)
        {
            var solver = new FindtheDifference_389();
            Assert.Equal(expected, solver.FindTheDifferenceMath(inputData1, inputData2));
        }
    }

    public class FindtheDifferenceTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "abcd",
                "abcde",
                'e'
            };

            yield return new object[]
            {
                "",
                "y",
                'y'
            };

            yield return new object[]
{
                "a",
                "aa",
                'a'
};
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}