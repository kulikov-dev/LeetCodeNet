using System.Collections;
using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class SpecialArrayWithXElementsGreaterThanorEqualX_1608_test
    {
        [Theory, ClassData(typeof(SpecialArrayWithXElementsGreaterThanorEqualXTestData))]
        public void Check(int[] inputData, int expected)
        {
            var solver = new SpecialArrayWithXElementsGreaterThanorEqualX_1608();
            var result = solver.SpecialArray(inputData);

            Assert.Equal(expected, result);
        }
    }

    public sealed class SpecialArrayWithXElementsGreaterThanorEqualXTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new []{3, 5},
                2
            };
            
            yield return new object[]
            {
                new []{0, 0},
                -1
            };

            yield return new object[]
            {
                new []{0,4,3,0,4},
                3
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
