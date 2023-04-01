using LeetCodeNet.Easy.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class ReplaceElementswithGreatestElementonRightSide_1299_test
    {
        [Theory, ClassData(typeof(ReplaceElementswithGreatestElementonRightSideTestData))]
        public void Check(int[] inputData, int[] expected)
        {
            var solver = new ReplaceElementswithGreatestElementonRightSide_1299();

            Assert.True(expected.SequenceEqual(solver.ReplaceElements(inputData)));
        }
    }

    public sealed class ReplaceElementswithGreatestElementonRightSideTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation:
            /// -index 0-- > the greatest element to the right of index 0 is index 1(18).
            /// - index 1-- > the greatest element to the right of index 1 is index 4(6).
            /// - index 2-- > the greatest element to the right of index 2 is index 4(6).
            /// - index 3-- > the greatest element to the right of index 3 is index 4(6).
            /// - index 4-- > the greatest element to the right of index 4 is index 5(1).
            /// - index 5-- > there are no elements to the right of index 5, so we put - 1.
            yield return new object[]
            {
                new[] { 17,18,5,4,6,1 },
                new[] { 18,6,6,6,1,-1 },
            };

            yield return new object[]
            {
                new[] { 400 },
                new[] { -1 },
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}