using LeetCodeNet.Easy.Strings;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Strings
{
    public class RansomNote_383_test
    {
        [Theory, ClassData(typeof(RansomNoteTestData))]
        public void CheckHash(string inputData1, string inputData2, bool expected)
        {
            var solver = new RansomNote_383();
            Assert.Equal(expected, solver.CanConstructHash(inputData1, inputData2));
        }

        [Theory, ClassData(typeof(RansomNoteTestData))]
        public void CheckArray(string inputData1, string inputData2, bool expected)
        {
            var solver = new RansomNote_383();
            Assert.Equal(expected, solver.CanConstructArray(inputData1, inputData2));
        }
    }

    public class RansomNoteTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "a",
                "b",
                false
            };

            yield return new object[]
            {
                "aa",
                "ab",
                false
            };

            yield return new object[]
{
                "aa",
                "aab",
                true
};
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
