using LeetCodeNet.Easy.Strings;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Strings
{
    public class MergeStringsAlternately_1768_test
    {
        [Theory, ClassData(typeof(MergeStringsAlternatelyTestData))]
        public void Check(string inputData1, string inputData2, string expected)
        {
            var solver = new MergeStringsAlternately_1768();
            Assert.Equal(expected, solver.MergeAlternately(inputData1, inputData2));
        }
    }

    public class MergeStringsAlternatelyTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: The merged string will be merged as so:
            /// word1: a b c
            /// word2:  p q r
            /// merged: a p b q c r
            yield return new object[]
            {
                "abc",
                "pqr",
                "apbqcr"
            };

            //// Notice that as word2 is longer, "rs" is appended to the end.
            yield return new object[]
            {
                "ab",
                "pqrs",
                "apbqrs"
            };

            yield return new object[]
{
                "abcd",
                "pq",
                "apbqcd"
};
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}