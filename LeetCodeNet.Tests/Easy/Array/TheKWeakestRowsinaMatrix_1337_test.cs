using System.Collections;
using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class TheKWeakestRowsinaMatrix_1337_test
    {
        [Theory, ClassData(typeof(TheKWeakestRowsinaMatrixTestData))]
        public void CheckLinq(int[][] inputData1, int inputData2, int[] expected)
        {
            var solver = new TheKWeakestRowsinaMatrix_1337();
            var result = solver.KWeakestRowsLinq(inputData1, inputData2);

            Assert.True(expected.SequenceEqual(result));
        }

        [Theory, ClassData(typeof(TheKWeakestRowsinaMatrixTestData))]
        public void CheckQueue(int[][] inputData1, int inputData2, int[] expected)
        {
            var solver = new TheKWeakestRowsinaMatrix_1337();
            var result = solver.KWeakestRowsQueue(inputData1, inputData2);

            Assert.True(expected.SequenceEqual(result));
        }
    }

    public sealed class TheKWeakestRowsinaMatrixTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation:
            /// The number of soldiers in each row is:
            /// -Row 0: 2
            /// - Row 1: 4
            /// - Row 2: 1
            /// - Row 3: 2
            /// - Row 4: 5
            /// The rows ordered from weakest to strongest are[2, 0, 3, 1, 4].
            yield return new object[]
            {
                new []
                {
                    new int[] {1,1,0,0,0},
                    new int[] {1,1,1,1,0},
                    new int[] {1,0,0,0,0},
                    new int[] {1,1,0,0,0},
                    new int[] {1,1,1,1,1},
                },
                3,
                new int[] { 2, 0, 3 }
            };

            yield return new object[]
            {
                new []
                {
                    new int[] {1,0,0,0},
                    new int[] {1,1,1,1},
                    new int[] {1,0,0,0},
                    new int[] {1,0,0,0},
                },
                2,
                new int[] { 0, 2 }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
