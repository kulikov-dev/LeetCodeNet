using LeetCodeNet.Medium.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Medium.Array
{
    public sealed class NumberofIslands_200_test
    {
        [Theory, ClassData(typeof(NumberofIslandsTestData))]
        public void Check(char[][] inputData, int expected)
        {
            var solver = new NumberofIslands_200();

            Assert.Equal(expected, solver.NumIslands(inputData));
        }
    }

    public sealed class NumberofIslandsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] { new[] { '1', '1', '1', '1', '0' }, new[] { '1', '1', '0', '1', '0' }, new[] { '1', '1', '0', '0', '0' }, new[] { '0', '0', '0', '0', '0' } },
                1
            };

            yield return new object[]
            {
                new[] { new[] { '1', '1', '0', '0', '0' }, new[] { '1', '1', '0', '0', '0' }, new[] { '0', '0', '1', '0', '0' }, new[] { '0', '0', '0', '1', '1' } },
                3
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
