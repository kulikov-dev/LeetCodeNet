using System.Collections;
using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class FindSmallestLetterGreaterThanTarget_744_test
    {
        [Theory, ClassData(typeof(FindSmallestLetterGreaterThanTargetTestData))]
        public void Check(char[] inputData1, char inputData2, char expected)
        {
            var solver = new FindSmallestLetterGreaterThanTarget_744();
            var result = solver.NextGreatestLetter(inputData1, inputData2);

            Assert.Equal(expected, result);
        }
    }

    public sealed class FindSmallestLetterGreaterThanTargetTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: The smallest character that is lexicographically greater than 'a' in letters is 'c'.
            yield return new object[]
            {
                new []{'c','f','j'},
                'a',
                'c'
            };

            //// Explanation: The smallest character that is lexicographically greater than 'c' in letters is 'f'.
            yield return new object[]
            {
                new []{'c','f','j'},
                'c',
                'f'
            };

            //// Explanation: There are no characters in letters that is lexicographically greater than 'z' so we return letters[0].
            yield return new object[]
            {
                new []{'x','x','y','y'},
                'z',
                'x'
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
