using System.Collections;
using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class CountNegativeNumbersinaSortedMatrix_1351_test
    {
        [Theory, ClassData(typeof(CountNegativeNumbersinaSortedMatrixTestData))]
        public void CheckSimple(int[][] inputData, int expected)
        {
            var solver = new CountNegativeNumbersinaSortedMatrix_1351();
            var result = solver.CountNegativesSimple(inputData);

            Assert.Equal(expected, result);
        }

        [Theory, ClassData(typeof(CountNegativeNumbersinaSortedMatrixTestData))]
        public void CheckBinarySearch(int[][] inputData, int expected)
        {
            var solver = new CountNegativeNumbersinaSortedMatrix_1351();
            var result = solver.CountNegativesBinarySearch(inputData);

            Assert.Equal(expected, result);
        }
    }

    public sealed class CountNegativeNumbersinaSortedMatrixTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new []{new[] {3,2}, new [] {1,0}},
                0
            };

            yield return new object[]
            {
                new []{new[] { 4, 3, 2, -1 }, new [] { 3, 2, 1, -1 }, new [] { 1, 1, -1, -2 } , new [] { -1, -1, -2, -3 }  },
                8
            };

            yield return new object[]
            {
                new []{new[] { 3, -1, -3, -3, -3 }, new [] { 2, -2, -3, -3, -3 }, new [] { 1, -2, -3, -3, -3 } , new [] { 0, -3, -3, -3, -3 }  },
                16
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
