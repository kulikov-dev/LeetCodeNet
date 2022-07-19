using LeetCodeNet.Easy.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Array
{
    public class PlusOne_66_test
    {
        [Theory, ClassData(typeof(PlusOneTestData))]
        public void Check(int[] inputData, int[] expected)
        {
            var solver = new PlusOne_66();
            Assert.Equal(expected, solver.PlusOne(inputData));
        }
    }

    public class PlusOneTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: The array represents the integer 123. Incrementing by one gives 123 + 1 = 124.
            /// Thus, the result should be[1, 2, 4].
            yield return new object[]
            {
                new int[] { 1, 2, 3 },
                new int[] { 1, 2, 4 }
            };

            yield return new object[]
            {
                new int[] { 4, 3, 2, 1 },
                new int[] { 4, 3, 2, 2 }
            };

            yield return new object[]
            {
                new int[] { 9 },
                new int[] { 1, 0 }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
