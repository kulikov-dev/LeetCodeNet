using LeetCodeNet.Easy.LeetMath;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.LeetMath
{
    public sealed class SignoftheProductofanArray_1822_test
    {
        [Theory, ClassData(typeof(SignoftheProductofanArrayTestData))]
        public void CheckSimple(int[] inputData, int expected)
        {
            var solver = new SignoftheProductofanArray_1822();

            Assert.Equal(expected, solver.ArraySign(inputData));
        }
    }

    public sealed class SignoftheProductofanArrayTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
               new int[]{ -1, -2, -3, -4, 3, 2, 1 },
               1
            };

            yield return new object[]
            {
              new int[]{ 1,5,0,2,-3 },
               0
            };

            yield return new object[]
            {
               new int[]{ -1,1,-1,1,-1 },
               -1
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}