using LeetCodeNet.Easy.Strings;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Strings
{
    public sealed class LetterCasePermutation_784_test
    {
        [Theory, ClassData(typeof(CountBinarySubstringsTestData))]
        public void Check(string inputData, int expected)
        {
            var solver = new CountBinarySubstrings_696();
            Assert.Equal(expected, solver.CountBinarySubstrings(inputData));
        }
    }

    public sealed class CountBinarySubstringsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: There are 6 substrings that have equal number of consecutive 1's and 0's: "0011", "01", "1100", "10", "0011", and "01".
            /// Notice that some of these substrings repeat and are counted the number of times they occur.
            /// Also, "00110011" is not a valid substring because all the 0's (and 1's) are not grouped together.
            yield return new object[]
            {
                "00110011",
                6
            };

            //// Explanation: There are 4 substrings: "10", "01", "10", "01" that have equal number of consecutive 1's and 0's.
            yield return new object[]
            {
                "10101",
                4
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
