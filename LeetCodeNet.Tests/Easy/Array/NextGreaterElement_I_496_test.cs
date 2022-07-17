using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public class NextGreaterElement_I_496_test
    {
        [Fact]
        public void CheckBruteForce()
        {
            var solver = new NextGreaterElement_I_496();

            //// Explanation: The next greater element for each value of nums1 is as follows:
            /// -4 is underlined in nums2 = [1, 3, 4, 2].There is no next greater element, so the answer is -1.
            /// - 1 is underlined in nums2 = [1, 3, 4, 2].The next greater element is 3.
            /// -2 is underlined in nums2 = [1, 3, 4, 2].There is no next greater element, so the answer is -1.
            var result = solver.NextGreaterElementBruteForce(new int[] { 4, 1, 2 }, new int[] { 1, 3, 4, 2 });
            Assert.Equal(new int[] { -1, 3, -1 }, result);

            result = solver.NextGreaterElementBruteForce(new int[] { 2, 4 }, new int[] { 1, 2, 3, 4 });
            Assert.Equal(new int[] { 3, -1 }, result);
        }

        [Fact]
        public void CheckStack()
        {
            var solver = new NextGreaterElement_I_496();

            //// Explanation: The next greater element for each value of nums1 is as follows:
            /// -4 is underlined in nums2 = [1, 3, 4, 2].There is no next greater element, so the answer is -1.
            /// - 1 is underlined in nums2 = [1, 3, 4, 2].The next greater element is 3.
            /// -2 is underlined in nums2 = [1, 3, 4, 2].There is no next greater element, so the answer is -1.
            var result = solver.NextGreaterElementStack(new int[] { 4, 1, 2 }, new int[] { 1, 3, 4, 2 });
            Assert.Equal(new int[] { -1, 3, -1 }, result);

            result = solver.NextGreaterElementStack(new int[] { 2, 4 }, new int[] { 1, 2, 3, 4 });
            Assert.Equal(new int[] { 3, -1 }, result);
        }
    }
}
