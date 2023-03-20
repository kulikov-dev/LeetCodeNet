using LeetCodeNet.Medium.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Medium.Array
{
    public sealed class Permutations_46_test
    {
        [Theory, ClassData(typeof(PermutationsTestData))]
        public void Check(int[] nums, List<List<int>> expected)
        {
            var solver = new Permutations_46();

            var result = solver.Permute(nums);

            Assert.Equal(expected.Count, result.Count);

            for (var i = 0; i < expected.Count; i++)
            {
                Assert.True(expected[i].SequenceEqual(result[i]));
            }
        }
    }

    public sealed class PermutationsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] {1,2,3},
               new List<List<int>>()
               {
                   new List<int>() {1,2,3},
                   new List<int>() {1,3,2},
                   new List<int>() {2,1,3},
                   new List<int>() {2,3,1},
                   new List<int>() {3,2,1},
                   new List<int>() {3, 1,2}
               }
            };

            yield return new object[]
            {
                new[] {0, 1},
                new List<List<int>>()
                {
                    new List<int>() {0,1},
                    new List<int>() {1,0},
                }
            };

            yield return new object[]
            {
                new[] {1},
                new List<List<int>>()
                {
                    new List<int>() {1}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
