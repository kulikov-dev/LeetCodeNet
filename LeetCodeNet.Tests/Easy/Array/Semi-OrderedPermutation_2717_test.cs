using System.Collections;
using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class SemiOrderedPermutation_2717_test
    {
        [Theory, ClassData(typeof(Semi_OrderedPermutationTestData))]
        public void Check(int[] inputData, int expected)
        {
            var solver = new Semi_OrderedPermutation_2717();
            var result = solver.SemiOrderedPermutation(inputData);

            Assert.Equal(expected, result);
        }
    }

    public sealed class Semi_OrderedPermutationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] {2,1,4,3},
                2
            };

            yield return new object[]
            {
                new[] {2,4,1,3},
                3
            };

            yield return new object[]
            {
                new[] {1,3,4,2,5},
                0
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
