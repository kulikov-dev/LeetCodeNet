using LeetCodeNet.Easy.Strings;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Strings
{
    public class CheckifOneStringSwapCanMakeStringsEqual_1790_test
    {
        [Theory, ClassData(typeof(CheckifOneStringSwapCanMakeStringsEqualTestData))]
        public void Check(string inputData1, string inputData2, bool expected)
        {
            var solver = new CheckifOneStringSwapCanMakeStringsEqual_1790();
            Assert.Equal(expected, solver.AreAlmostEqual(inputData1, inputData2));
        }
    }

    public class CheckifOneStringSwapCanMakeStringsEqualTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: For example, swap the first character with the last character of s2 to make "bank".
            yield return new object[]
            {
                "bank",
                "kanb",
                true
            };

            //// Explanation: It is impossible to make them equal with one string swap.
            yield return new object[]
            {
                "attack",
                "defend",
                false
            };

            //// Explanation: The two strings are already equal, so no string swap operation is required.
            yield return new object[]
            {
                "kelb",
                "kelb",
                true
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}