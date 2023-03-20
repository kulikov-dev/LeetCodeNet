using LeetCodeNet.Easy.Strings;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Strings
{
    public sealed class VerifyinganAlienDictionary_953_test
    {
        [Theory, ClassData(typeof(VerifyinganAlienDictionaryTestData))]
        public void Check(string[] inputData, string inputOrder, bool expected)
        {
            var solver = new VerifyinganAlienDictionary_953();

            Assert.Equal(expected, solver.IsAlienSorted(inputData, inputOrder));
        }
    }

    public sealed class VerifyinganAlienDictionaryTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: As 'h' comes before 'l' in this language, then the sequence is sorted.
            yield return new object[]
            {
                new[] { "hello", "leetcode" },
                "hlabcdefgijkmnopqrstuvwxyz",
                true
            };

            //// Explanation: As 'd' comes after 'l' in this language, then words[0] > words[1], hence the sequence is unsorted.
            yield return new object[]
            {
                new[] { "word", "world", "row" },
                "worldabcefghijkmnpqstuvxyz",
                false
            };

            //// Explanation: The first three characters "app" match, and the second string is shorter (in size.)
            /// According to lexicographical rules "apple" > "app", because 'l' > '∅', where '∅' is defined as the blank character which is less than any other character
            yield return new object[]
            {
                new[] { "apple", "app" },
               "abcdefghijklmnopqrstuvwxyz",
               false
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
