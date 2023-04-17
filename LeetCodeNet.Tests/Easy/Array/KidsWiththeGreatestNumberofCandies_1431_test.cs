using LeetCodeNet.Easy.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class KidsWiththeGreatestNumberofCandies_1431_test
    {
        [Theory, ClassData(typeof(KidsWiththeGreatestNumberofCandiesTestData))]
        public void CheckCommon(int[] inputData1, int inputData2, bool[] expected)
        {
            var solver = new KidsWiththeGreatestNumberofCandies_1431();

            Assert.True(expected.SequenceEqual(solver.KidsWithCandiesCommon(inputData1, inputData2)));
        }

        [Theory, ClassData(typeof(KidsWiththeGreatestNumberofCandiesTestData))]
        public void CheckLinq(int[] inputData1, int inputData2, bool[] expected)
        {
            var solver = new KidsWiththeGreatestNumberofCandies_1431();

            Assert.True(expected.SequenceEqual(solver.KidsWithCandiesLinq(inputData1, inputData2)));
        }
    }

    public sealed class KidsWiththeGreatestNumberofCandiesTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] { 2,3,5,1,3 },
                3,
                new[] {true, true, true, false ,true }
            };

            yield return new object[]
            {
                new[] { 4,2,1,1,2 },
                1,
                new[] {true, false,false, false ,false }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}