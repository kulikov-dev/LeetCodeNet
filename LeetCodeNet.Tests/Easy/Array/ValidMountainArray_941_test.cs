using LeetCodeNet.Easy.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class ValidMountainArray_941_test
    {
        [Theory, ClassData(typeof(ValidMountainArrayTestData))]
        public void CheckLinq(int[] inputData, bool expected)
        {
            var solver = new ValidMountainArray_941();

            Assert.Equal(expected, solver.ValidMountainArray(inputData));
        }
    }

    public sealed class ValidMountainArrayTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] { 2, 1 },
                false
            };

            yield return new object[]
            {
                new[] { 3,5,5 },
                false
            };

            yield return new object[]
            {
                new[] { 0,3,2,1 },
                true
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
