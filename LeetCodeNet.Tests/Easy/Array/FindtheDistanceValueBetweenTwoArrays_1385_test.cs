using LeetCodeNet.Easy.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class FindtheDistanceValueBetweenTwoArrays_1385_test
    {
        [Theory, ClassData(typeof(FindtheDistanceValueBetweenTwoArraysTestData))]
        public void CheckSimple(int[] inputData1, int[] inputData2, int inputData3, int expected)
        {
            var solver = new FindtheDistanceValueBetweenTwoArrays_1385();

            Assert.Equal(expected, solver.FindTheDistanceValueSimple(inputData1, inputData2, inputData3));
        }

        [Theory, ClassData(typeof(FindtheDistanceValueBetweenTwoArraysTestData))]
        public void CheckSort(int[] inputData1, int[] inputData2, int inputData3, int expected)
        {
            var solver = new FindtheDistanceValueBetweenTwoArrays_1385();

            Assert.Equal(expected, solver.FindTheDistanceValueSort(inputData1, inputData2, inputData3));
        }
    }

    public sealed class FindtheDistanceValueBetweenTwoArraysTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] { 4,5,8 },
                new[] { 10,9,1,8 },
                2,
                2
            };

            yield return new object[]
            {
                new[] { 1,4,2,3 },
                new[] { -4,-3,6,10,20,30 },
               3,
                2
            };

            yield return new object[]
            {
                new[] {2,1,100,3 },
                new[] { -5,-2,10,-3,7 },
                6,
                1
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}