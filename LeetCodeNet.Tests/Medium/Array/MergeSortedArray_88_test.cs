using LeetCodeNet.Medium.Array;
using System.Collections;
using System.Xml.Linq;

namespace LeetCodeNet.Tests.Medium.Array
{
    public sealed class MergeSortedArray_88_test
    {
        [Theory, ClassData(typeof(MergeSortedArrayTestData))]
        public void Check(int[] nums1, int m, int[] nums2, int n, int[] expected)
        {
            var solver = new MergeSortedArray_88();

            solver.Merge(nums1, m, nums2, n);
            Assert.True(expected.SequenceEqual(nums1));
        }
    }

    public sealed class MergeSortedArrayTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
            /// The result of the merge is [1, 2, 2, 3, 5, 6] with the underlined elements coming from nums1.
            yield return new object[]
             {
                new int[] {1,2,3,0,0,0},
               3,
               new int[] {2,5,6},
               3,
               new int[] {1,2,2,3,5,6},
             };

            //// Explanation: The arrays we are merging are [1] and [].
            /// The result of the merge is [1].
            yield return new object[]
            {
                new int[] {1},
                1,
                new int[] {},
                0,
                new int[] {1},
            };

            yield return new object[]
            {
                new int[] {0},
                0,
                new int[] {1},
                1,
                new int[] {1},
            };

            yield return new object[]
            {
                new int[] {2, 0},
                1,
                new int[] {1},
                1,
                new int[] {1, 2},
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
