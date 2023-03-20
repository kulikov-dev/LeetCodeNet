using System.Collections;
using LeetCodeNet.Easy.LeetMath;

namespace LeetCodeNet.Tests.Easy.LeetMath
{
    public sealed class LargestPerimeterTriangle_976_test
    {
        [Theory, ClassData(typeof(LargestPerimeterTriangleTestData))]
        public void CheckSimple(int[] inputData, int expected)
        {
            var solver = new LargestPerimeterTriangle_976();
            var result = solver.LargestPerimeter(inputData);

            Assert.Equal(expected, result);
        }
    }

    public sealed class LargestPerimeterTriangleTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: You can form a triangle with three side lengths: 1, 2, and 2.
            yield return new object[]
            {
                new[] {2,1,2},
                5
            };

            ////You cannot use the side lengths 1, 1, and 2 to form a triangle.
            /// You cannot use the side lengths 1, 1, and 10 to form a triangle.
            /// You cannot use the side lengths 1, 2, and 10 to form a triangle.
            /// As we cannot use any three side lengths to form a triangle of non-zero area, we return 0.
            yield return new object[]
            {
                new[] {1,2,1,10},
                0
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
