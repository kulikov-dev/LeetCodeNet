using System.Collections;
using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class FindAllNumbersDisappearedinanArray_448_test
    {
        [Theory, ClassData(typeof(FindAllNumbersDisappearedinanArrayTestData))]
        public void CheckSimple(int[] inputData, int[] expected)
        {
            var solver = new FindAllNumbersDisappearedinanArray_448();

            Assert.True(expected.SequenceEqual(solver.FindDisappearedNumbersSimple(inputData)));
        }

        [Theory, ClassData(typeof(FindAllNumbersDisappearedinanArrayTestData))]
        public void CheckSort(int[] inputData, int[] expected)
        {
            var solver = new FindAllNumbersDisappearedinanArray_448();

            Assert.True(expected.SequenceEqual(solver.FindDisappearedNumbersSort(inputData)));
        }
    }

    public sealed class FindAllNumbersDisappearedinanArrayTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new []{4,3,2,7,8,2,3,1},
                new []{5,6},
            };

            yield return new object[]
            {
                new []{1, 1},
                new []{2},
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
