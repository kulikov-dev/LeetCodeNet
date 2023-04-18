using LeetCodeNet.Medium.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Medium.Array
{
    public sealed class CourseSchedule_207_test
    {
        [Theory, ClassData(typeof(CourseScheduleTestData))]
        public void Check(int inputData1, int[][] inputData2, bool expected)
        {
            var solver = new CourseSchedule_207();

            Assert.Equal(expected, solver.CanFinish(inputData1, inputData2));
        }
    }

    public sealed class CourseScheduleTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: There are a total of 2 courses to take.
            /// To take course 1 you should have finished course 0.So it is possible.
            yield return new object[]
            {
                2,
                new[] {new[] {1,0} },
                true
            };

            //// Explanation: There are a total of 2 courses to take.
            /// To take course 1 you should have finished course 0, and to take course 0 you should also have finished course 1.So it is impossible.
            yield return new object[]
            {
                2,
                new[] {new[] {1,0}, new[] {0,1} },
                false
            };

            yield return new object[]
            {
                3,
                new[] {new[] {1,0}, new[] {1,2}, new[] {0,1}  },
                false
            };

            yield return new object[]
            {
                5,
                new[] {new[] {1,4}, new[] {2, 4}, new[] {3,1}, new[] {3,2}  },
                true
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
