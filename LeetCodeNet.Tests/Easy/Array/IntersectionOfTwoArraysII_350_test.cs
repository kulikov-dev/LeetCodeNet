using LeetCodeNet.Easy.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Array
{
    public class IntersectionOfTwoArraysII_350_test
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

    public class IntersectionOfTwoArraysIITestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new int[] { 1, 2, 2, 1 },
                new int[] { 2 },
                new int[] { 2 }
            };

            yield return new object[]
            {
                new int[] { 1, 2, 2, 1 },
                new int[] { 2, 2 },
                new int[] { 2, 2 }
            };

            yield return new object[]
{
               new int[] { 4, 9, 5 },
               new int[] { 9, 4, 9, 8, 4 },
               new int[] { 4,9 }
};
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
