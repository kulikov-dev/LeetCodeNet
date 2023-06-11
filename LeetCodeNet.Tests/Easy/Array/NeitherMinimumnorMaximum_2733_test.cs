using System.Collections;
using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class NeitherMinimumnorMaximum_2733_test
    {
        [Theory, ClassData(typeof(NeitherMinimumnorMaximumTestData))]
        public void Check(int[] inputData, int[] expected)
        {
            var solver = new NeitherMinimumnorMaximum_2733();
            var result = solver.FindNonMinOrMax(inputData);

            Assert.True(expected.Contains(result));
        }

        [Theory, ClassData(typeof(NeitherMinimumnorMaximumTestData))]
        public void CheckSort(int[] inputData, int[] expected)
        {
            var solver = new NeitherMinimumnorMaximum_2733();
            var result = solver.FindNonMinOrMaxSort(inputData);

            Assert.True(expected.Contains(result));
        }
    }

    public sealed class NeitherMinimumnorMaximumTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new [] { 3, 2, 1, 4 },
                new[] {3,2}
            };

            yield return new object[]
            {
                new [] { 1 ,2 },
                new [] {-1}
            };

            yield return new object[]
            {
                new [] { 2, 1 , 3},
                new [] {2}
            };

            yield return new object[]
            {
                new [] { 6, 4},
                new [] {-1}
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
