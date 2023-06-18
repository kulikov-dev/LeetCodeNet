using LeetCodeNet.Medium.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Medium.Array
{
    public sealed class NumberofAdjacentElementsWiththeSameColor_2672_test
    {
        [Theory, ClassData(typeof(NumberofAdjacentElementsWiththeSameColorTestData))]
        public void Check(int[][] input1, int input2, int[] expected)
        {
            var solver = new NumberofAdjacentElementsWiththeSameColor_2672();

            Assert.True(expected.SequenceEqual(solver.ColorAdjacentElements(input1, input2)));
        }
    }

    public sealed class NumberofAdjacentElementsWiththeSameColorTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: Initially array nums = [0,0,0,0], where 0 denotes uncolored elements of the array.
            /// -After the 1st query nums = [2, 0, 0, 0].The count of adjacent elements with the same color is 0.
            /// - After the 2nd query nums = [2, 2, 0, 0].The count of adjacent elements with the same color is 1.
            /// - After the 3rd query nums = [2, 2, 0, 1].The count of adjacent elements with the same color is 1.
            /// - After the 4th query nums = [2, 1, 0, 1].The count of adjacent elements with the same color is 0.
            yield return new object[]
            {
                new int[][] {new[] {0,2}, new[] {1,2}, new[] {3,1}, new[] { 1, 1 }, new[] { 2, 1 } },
                4,
                new int[] { 0, 1, 1, 0, 2 }
            };

            yield return new object[]
            {
                new int[][] {new[] {0, 10000 } },
                1,
                new int[] {0}
            };

            yield return new object[]
            {
                new int[][] {new [] {6,2}, new[] { 2,1}, new[] { 0,6},new[] { 0, 1 },new[] { 0, 4 },new[] { 0, 1 },new[] { 5, 7 },new[] { 5, 3 },new[] { 7, 6 },new[] { 6, 7}, new[] { 4, 6 },new[] { 4, 2 },new[] { 5, 1 }, new[] { 3,7}, new[] { 4,4}, new[] { 5,1} },
                8,
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };

            yield return new object[]
            {
                new int[][] { new[]{11,3},new[] {5,1},new[] {16,2},new[] {4,4},new[] {5,1},new[] {13,2},new[] {15,1},new[] {15,3},new[] {8,1},new[] {14,4},new[] {1,3},new[] {6,2},new[] {8,2},new[] {2,2},new[] {3,4},new[] {7,1},new[] {10,2},new[] {14,3},new[] {6,5},new[] {3,5},new[] {5,5},new[] {9,2},new[] {2,3},new[] {3,3},new[] {4,1},new[] {12,1},new[] {0,4},new[] {16,4},new[] {8,1},new[] {14,3},new[] {15,3},new[] {12,1},new[] {11,5},new[] {3,1},new[] {2,4},new[] {10,1},new[] {14,5},new[] {15,5},new[] {5,2},new[] {8,1},new[] {6,5},new[] {10,2} },
                17,
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 2, 2, 1, 2, 4, 5, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 5, 4, 3, 4, 3, 3, 3, 4 }
            };


        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
