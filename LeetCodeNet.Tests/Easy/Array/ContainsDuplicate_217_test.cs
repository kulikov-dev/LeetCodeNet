using LeetCodeNet.Easy.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class ContainsDuplicate_217_test
    {
        [Theory, ClassData(typeof(ContainsDuplicateTestData))]
        public void CheckLinq(int[] inputData, bool expected)
        {
            var solver = new ContainsDuplicate_217();

            Assert.Equal(expected, solver.ContainsDuplicateLinq(inputData));
        }

        [Theory, ClassData(typeof(ContainsDuplicateTestData))]
        public void CheckHash(int[] inputData, bool expected)
        {
            var solver = new ContainsDuplicate_217();

            Assert.Equal(expected, solver.ContainsDuplicateHash(inputData));
        }

        [Theory, ClassData(typeof(ContainsDuplicateTestData))]
        public void CheckSorting(int[] inputData, bool expected)
        {
            var solver = new ContainsDuplicate_217();

            Assert.Equal(expected, solver.ContainsDuplicateSorting(inputData));
        }
    }

    public sealed class ContainsDuplicateTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new int[] { 1, 2, 3, 1 },
                true
            };

            yield return new object[]
            {
                new int[] { 1, 2, 3, 4 },
                false
            };

            yield return new object[]
            {
                new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 },
                true
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
