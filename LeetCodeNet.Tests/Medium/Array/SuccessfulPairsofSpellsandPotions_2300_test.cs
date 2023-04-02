using LeetCodeNet.Medium.Array;
using Moq;
using System.Collections;

namespace LeetCodeNet.Tests.Medium.Array
{
    public sealed class SuccessfulPairsofSpellsandPotions_2300_test
    {
        [Theory, ClassData(typeof(SuccessfulPairsofSpellsandPotionsTestData))]
        public void Check(int[] inputData1, int[] inputData2, int inputData3, int[] expected)
        {
            var solver = new SuccessfulPairsofSpellsandPotions_2300();

            Assert.True(expected.SequenceEqual(solver.SuccessfulPairs(inputData1, inputData2, inputData3)));
        }
    }

    public sealed class SuccessfulPairsofSpellsandPotionsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation:
            /// -0 th spell: 5 * [1, 2, 3, 4, 5] = [5, 10, 15, 20, 25]. 4 pairs are successful.
            /// - 1st spell: 1 * [1, 2, 3, 4, 5] = [1, 2, 3, 4, 5]. 0 pairs are successful.
            /// - 2nd spell: 3 * [1, 2, 3, 4, 5] = [3, 6, 9, 12, 15]. 3 pairs are successful.
            /// Thus, [4,0,3] is returned.
            yield return new object[]
            {
                new[] { 5, 1, 3 },
                new[] {1, 2, 3, 4, 5 },
                7,
                new [] { 4, 0, 3 }
            };

            yield return new object[]
            {
                new[] { 3, 1, 2 },
                new[] {8, 5, 8 },
                16,
                new [] { 2, 0, 2 }
            };

            yield return new object[]
            {
                new[] { 40,11,24,28,40,22,26,38,28,10,31,16,10,37,13,21,9,22,21,18,34,2,40,40,6,16,9,14,14,15,37,15,32,4,27,20,24,12,26,39,32,39,20,19,22,33,2,22,9,18,12,5 },
                new[] { 31,40,29,19,27,16,25,8,33,25,36,21,7,27,40,24,18,26,32,25,22,21,38,22,37,34,15,36,21,22,37,14,31,20,36,27,28,32,21,26,33,37,27,39,19,36,20,23,25,39,40 },
                600,
                new [] { 48, 0, 32, 37, 48, 22, 33, 47, 37, 0, 43, 6, 0, 46, 0, 21, 0, 22, 21, 14, 46, 0, 48, 48, 0, 6, 0, 0, 0, 3, 46, 3, 45, 0, 34, 20, 32, 0, 33, 47, 45, 47, 20, 18, 22, 45, 0, 22, 0, 14, 0, 0 }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
