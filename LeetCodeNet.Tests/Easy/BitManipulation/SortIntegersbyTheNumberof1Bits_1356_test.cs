using System.Collections;
using LeetCodeNet.Easy.BitManipulation;

namespace LeetCodeNet.Tests.Easy.BitManipulation
{
    public sealed class SortIntegersbyTheNumberof1Bits_1356_test
    {
        [Theory, ClassData(typeof(SortIntegersbyTheNumberof1BitsTestData))]
        public void CheckLinq(int[] inputData, int[] expected)
        {
            var solver = new SortIntegersbyTheNumberof1Bits_1356();
            var result = solver.SortByBitsLinq(inputData);

            Assert.True(expected.SequenceEqual(result));
        }

        [Theory, ClassData(typeof(SortIntegersbyTheNumberof1BitsTestData))]
        public void CheckData(int[] inputData, int[] expected)
        {
            var solver = new SortIntegersbyTheNumberof1Bits_1356();
            var result = solver.SortByBitsData(inputData);

            Assert.True(expected.SequenceEqual(result));
        }
    }

    public sealed class SortIntegersbyTheNumberof1BitsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new int[]{ 0, 1, 2, 3, 4, 5, 6, 7, 8 },
                new int[]{ 0, 1, 2, 4, 8, 3, 5, 6, 7 }
            };

            yield return new object[]
            {
                new int[] { 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1 },
                new int[] { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024 }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
