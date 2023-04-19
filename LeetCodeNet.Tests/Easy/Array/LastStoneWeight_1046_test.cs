using System.Collections;
using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class LastStoneWeight_1046_test
    {
        [Theory, ClassData(typeof(LastStoneWeightTestData))]
        public void CheckSort(int[] inputData, int expected)
        {
            var solver = new LastStoneWeight_1046();
            var result = solver.LastStoneWeightSort(inputData);

            Assert.Equal(expected, result);
        }

        [Theory, ClassData(typeof(LastStoneWeightTestData))]
        public void CheckQueue(int[] inputData, int expected)
        {
            var solver = new LastStoneWeight_1046();
            var result = solver.LastStoneWeightQueue(inputData);

            Assert.Equal(expected, result);
        }
    }

    public sealed class LastStoneWeightTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation:
            /// We combine 7 and 8 to get 1 so the array converts to[2, 4, 1, 1, 1] then,
            /// we combine 2 and 4 to get 2 so the array converts to[2, 1, 1, 1] then,
            /// we combine 2 and 1 to get 1 so the array converts to[1, 1, 1] then,
            /// we combine 1 and 1 to get 0 so the array converts to[1] then that's the value of the last stone.
            yield return new object[]
            {
                new []{2,7,4,1,8,1},
                1
            };

            yield return new object[]
            {
                new []{1},
                1
            };

            yield return new object[]
            {
                new []{2 ,2},
                0
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
