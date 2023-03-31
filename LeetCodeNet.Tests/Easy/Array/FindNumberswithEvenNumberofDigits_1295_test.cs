using System.Collections;
using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class FindNumberswithEvenNumberofDigits_1295_test
    {
        [Theory, ClassData(typeof(FindNumberswithEvenNumberofDigitsTestData))]
        public void Check(int[] inputData, int expected)
        {
            var solver = new FindNumberswithEvenNumberofDigits_1295();
            var result = solver.FindNumbers(inputData);

            Assert.Equal(expected, result);
        }
    }

    public sealed class FindNumberswithEvenNumberofDigitsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new []{12,345,2,6,7896},
                2
            };

            yield return new object[]
            {
                new []{555,901,482,1771},
                1
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
