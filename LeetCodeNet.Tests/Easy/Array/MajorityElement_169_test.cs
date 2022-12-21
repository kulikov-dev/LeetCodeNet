using System.Collections;
using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class MajorityElement_169_test
    {
        [Theory, ClassData(typeof(MajorityElementTestData))]
        public void Check(int[] inputData, int expected)
        {
            var solver = new MajorityElement_169();
            var result = solver.MajorityElement(inputData);
            Assert.Equal(expected, result);
        }
    }

    public sealed class MajorityElementTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: 9 exists in nums and its index is 4
            yield return new object[]
            {
                new []{3,2,3},
                3
            };

            //// Explanation: 2 does not exist in nums so return -1
            yield return new object[]
            {
                new []{2,2,1,1,1,2,2},
                2
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
