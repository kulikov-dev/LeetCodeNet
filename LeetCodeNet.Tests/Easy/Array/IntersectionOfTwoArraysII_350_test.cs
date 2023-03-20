using LeetCodeNet.Easy.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class IntersectionOfTwoArraysII_350_test
    {
        [Theory, ClassData(typeof(IntersectionOfTwoArraysIITestData))]
        public void CheckHash(int[] inputData1, int[] inputData2, int[] expected)
        {
            var solver = new IntersectionOfTwoArraysII_350();

            Assert.Equal(expected, solver.IntersectHash(inputData1, inputData2).OrderBy(x=>x).ToArray());
        }

        [Theory, ClassData(typeof(IntersectionOfTwoArraysIITestData))]
        public void CheckSorting(int[] inputData1, int[] inputData2, int[] expected)
        {
            var solver = new IntersectionOfTwoArraysII_350();

            Assert.Equal(expected, solver.IntersectSorted(inputData1, inputData2).OrderBy(x => x).ToArray());
        }
    }

    public sealed class IntersectionOfTwoArraysIITestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] { 1, 2, 2, 1 },
                new[] { 2 },
                new[] { 2 }
            };

            yield return new object[]
            {
                new[] { 1, 2, 2, 1 },
                new[] { 2, 2 },
                new[] { 2, 2 }
            };

            yield return new object[]
{
               new[] { 4, 9, 5 },
               new[] { 9, 4, 9, 8, 4 },
               new[] { 4,9 }
};
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
