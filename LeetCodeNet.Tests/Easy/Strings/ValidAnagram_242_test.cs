using System.Collections;

namespace LeetCodeNet.Tests.Easy.Strings
{
    public class ValidAnagram_242_test
    {
        [Theory, ClassData(typeof(ValidAnagramTestData))]
        public void CheckHash(string inputWord1, string inputWord2, bool expected)
        {
            var solver = new ValidAnagram_242();
            Assert.Equal(expected, solver.IsAnagramHash(inputWord1, inputWord2));
        }

        [Theory, ClassData(typeof(ValidAnagramTestData))]
        public void CheckSorting(string inputWord1, string inputWord2, bool expected)
        {
            var solver = new ValidAnagram_242();
            Assert.Equal(expected, solver.IsAnagramSorting(inputWord1, inputWord2));
        }
    }

    public class ValidAnagramTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "anagram",
                "nagaram",
                true
            };

            yield return new object[]
            {
                "rat",
                "car",
                false
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
