using System.Collections;
using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class RemoveElement_27_test
    {
        [Theory, ClassData(typeof(RemoveElementTestData))]
        public void Check(int[] inputData1, int inputData2, int expected)
        {
            var solver = new RemoveElement_27();
            var result = solver.RemoveElement(inputData1, inputData2);

            Assert.Equal(expected, result);
        }
    }

    public sealed class RemoveElementTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new []{3,2,2,3},
                3,
                2
            };

            yield return new object[]
            {
                new []{0,1,2,2,3,0,4,2},
                2,
                5
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
