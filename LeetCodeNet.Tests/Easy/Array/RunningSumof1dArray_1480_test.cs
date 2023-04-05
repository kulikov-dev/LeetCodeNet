using System.Collections;
using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class RunningSumof1dArray_1480_test
    {
        [Theory, ClassData(typeof(RunningSumof1dArrayTestData))]
        public void Check(int[] inputData, int[] expected)
        {
            var solver = new RunningSumof1dArray_1480();

            Assert.True(expected.SequenceEqual(solver.RunningSum(inputData)));
        }
    }

    public sealed class RunningSumof1dArrayTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].
            yield return new object[]
            {
                new []{1,2,3,4},
                new []{1,3,6,10}
            };

            //// Explanation: Running sum is obtained as follows: [1, 1+1, 1+1+1, 1+1+1+1, 1+1+1+1+1].
            yield return new object[]
            {
                new []{1,1,1,1,1},
                new []{1,2,3,4,5}
            };

            yield return new object[]
            {
                new []{ 3,1,2,10,1 },
                new []{ 3,4,6,16,17 },
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
