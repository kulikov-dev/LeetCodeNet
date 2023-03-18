using LeetCodeNet.Easy.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class NextGreaterElement_I_496_test
    {
        [Theory, ClassData(typeof(CheckBruteForceTestData))]
        public void CheckBruteForce(int[] inputData1, int[] inputData2, int[] expected)
        {
            var solver = new NextGreaterElement_I_496();
            var result = solver.NextGreaterElementBruteForce(inputData1, inputData2);

            Assert.Equal(expected, result);
        }

        [Theory, ClassData(typeof(CheckBruteForceTestData))]
        public void CheckStack(int[] inputData1, int[] inputData2, int[] expected)
        {
            var solver = new NextGreaterElement_I_496();
            var result = solver.NextGreaterElementStack(inputData1, inputData2);

            Assert.Equal(expected, result);
        }
    }

    public sealed class CheckBruteForceTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: The next greater element for each value of nums1 is as follows:
            /// -4 is underlined in nums2 = [1, 3, 4, 2].There is no next greater element, so the answer is -1.
            /// - 1 is underlined in nums2 = [1, 3, 4, 2].The next greater element is 3.
            /// -2 is underlined in nums2 = [1, 3, 4, 2].There is no next greater element, so the answer is -1.
            yield return new object[]
            {
                new int[] { 4, 1, 2 },
                new int[] { 1, 3, 4, 2 },
                new int[] { -1, 3, -1 }
            };

            yield return new object[]
            {
                new int[] { 2, 4 },
                new int[] { 1, 2, 3, 4 },
                new int[] { 3, -1 }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
