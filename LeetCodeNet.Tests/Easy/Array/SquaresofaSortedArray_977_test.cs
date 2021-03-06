using LeetCodeNet.Easy.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Array
{
    public class SquaresofaSortedArray_977_test
    {
        [Theory, ClassData(typeof(SquaresofaSortedArrayTestData))]
        public void CheckBruteForce(int[] inputData, int[] expected)
        {
            var solver = new SquaresofaSortedArray_977();
            Assert.Equal(expected, solver.SortedSquaresBruteForce(inputData));
        }

        [Theory, ClassData(typeof(SquaresofaSortedArrayTestData))]
        public void CheckPointers(int[] inputData, int[] expected)
        {
            var solver = new SquaresofaSortedArray_977();
            Assert.Equal(expected, solver.SortedSquaresPointers(inputData));
        }
    }

    public class SquaresofaSortedArrayTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: After squaring, the array becomes [16,1,0,9,100]. After sorting, it becomes[0, 1, 9, 16, 100].
            yield return new object[]
            {
                new int[] { -4, -1, 0, 3, 10 },
                new int[] { 0, 1, 9, 16, 100 }
            };

            yield return new object[]
            {
                new int[] { -7, -3, 2, 3, 11 },
                new int[] { 4, 9, 9, 49, 121 }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}