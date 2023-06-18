using LeetCodeNet.Medium.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Medium.Array
{
    public sealed class FindtheValueofthePartition_2740_test
    {
        [Theory, ClassData(typeof(FindtheValueofthePartitionTestData))]
        public void Check(int[] inputData, int expected)
        {
            var solver = new FindtheValueofthePartition_2740();

            Assert.Equal(expected, solver.MinPartitionValue(inputData));
        }
    }

    public sealed class FindtheValueofthePartitionTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new int[] {1,2,3,4},
                1
            };

            yield return new object[]
            {
                new int[] {100, 1, 10},
                9
            };

            yield return new object[]
            {
                new int[] {-2, -1, 10, 20 , 30},
                1
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
