using System.Collections;
using LeetCodeNet.Medium.DP;

namespace LeetCodeNet.Tests.Medium.DP
{
    public sealed class UniquePaths_62_test
    {
        [Theory, ClassData(typeof(UniquePathsTestData))]
        public void CheckRecursive(int inputData1, int inputData2, int expected)
        {
            var solver = new UniquePaths_62();

            Assert.Equal(expected, solver.UniquePathsRecursive(inputData1, inputData2));
        }

        [Theory, ClassData(typeof(UniquePathsTestData))]
        public void CheckBottomUp(int inputData1, int inputData2, int expected)
        {
            var solver = new UniquePaths_62();

            Assert.Equal(expected, solver.UniquePathsBottomUp(inputData1, inputData2));
        }

        [Theory, ClassData(typeof(UniquePathsTestData))]
        public void CheckBottomUpOptimized(int inputData1, int inputData2, int expected)
        {
            var solver = new UniquePaths_62();

            Assert.Equal(expected, solver.UniquePathsBottomUpOptimized(inputData1, inputData2));
        }
    }

    public sealed class UniquePathsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                3,
                7,
                28
            };

            //// Explanation: From the top-left corner, there are a total of 3 ways to reach the bottom-right corner:
            /// 1.Right->Down->Down
            /// 2.Down->Down->Right
            /// 3.Down->Right->Down
            yield return new object[]
            {
                3,
                2,
                3
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}