using LeetCodeNet.Easy.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class HeightChecker_1051_test
    {
        [Theory, ClassData(typeof(HeightCheckerTestData))]
        public void CheckSorting(int[] inputData, double expected)
        {
            var solver = new HeightChecker_1051();

            Assert.Equal(expected, solver.HeightCheckerSort(inputData));
        }

        [Theory, ClassData(typeof(HeightCheckerTestData))]
        public void CheckBucket(int[] inputData, double expected)
        {
            var solver = new HeightChecker_1051();

            Assert.Equal(expected, solver.HeightCheckerBucket(inputData));
        }
    }

    public sealed class HeightCheckerTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] { 1,1,4,2,1,3 },
                3
            };

            yield return new object[]
            {
                new[] { 5,1,2,3,4 },
                5
            };

            yield return new object[]
            {
                new[] { 1,2,3,4,5 },
                0
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}