using System.Collections;
using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class DuplicateZeros_1089_test
    {
        [Theory, ClassData(typeof(DuplicateZerosTestData))]
        public void Check(int[] inputData, int[] expected)
        {
            var solver = new DuplicateZeros_1089();
            solver.DuplicateZeros(inputData);

            Assert.True(inputData.SequenceEqual(expected));
        }
    }

    public sealed class DuplicateZerosTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new []{1,0,2,3,0,4,5,0},
                new[] { 1, 0, 0, 2, 3, 0, 0, 4 }
            };

            yield return new object[]
            {
                new []{ 1, 2, 3 },
                new []{ 1, 2, 3 },
            };

            yield return new object[]
            {
                new []{ 8,5,0,9,0,3,4,7},
                new[] { 8,5,0,0,9,0,0,3 }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
