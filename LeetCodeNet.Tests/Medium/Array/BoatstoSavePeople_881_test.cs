using LeetCodeNet.Medium.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Medium.Array
{
    public sealed class BoatstoSavePeople_881_test
    {
        [Theory, ClassData(typeof(BoatstoSavePeopleTestData))]
        public void CheckSimple(int[] inputData1, int inputData2, int expected)
        {
            var solver = new BoatstoSavePeople_881();

            Assert.Equal(expected, solver.NumRescueBoatsSimple(inputData1, inputData2));
        }

        [Theory, ClassData(typeof(BoatstoSavePeopleTestData))]
        public void CheckOptimized(int[] inputData1, int inputData2, int expected)
        {
            var solver = new BoatstoSavePeople_881();

            Assert.Equal(expected, solver.NumRescueBoatsOptimized(inputData1, inputData2));
        }
    }

    public sealed class BoatstoSavePeopleTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: 1 boat (1, 2)
            yield return new object[]
            {
                new[] { 1, 2 },
                3,
                1
            };

            //// Explanation: 3 boats (1, 2), (2) and (3)
            yield return new object[]
            {
                new[] { 3,2,2,1 },
                3,
                3
            };

            //// Explanation: 4 boats (3), (3), (4), (5)
            yield return new object[]
            {
                new[] { 3,5,3,4 },
                5,
                4
            };

            yield return new object[]
            {
                new[] { 21,40,16,24,30 },
                50,
                3
            };

            yield return new object[]
            {
                new[] { 3,2,3,2,2 },
                6,
                3
            };

            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
