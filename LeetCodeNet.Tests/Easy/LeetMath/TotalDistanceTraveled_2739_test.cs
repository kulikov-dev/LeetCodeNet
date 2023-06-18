using System.Collections;
using LeetCodeNet.Easy.LeetMath;

namespace LeetCodeNet.Tests.Easy.LeetMath
{
    public sealed class TotalDistanceTraveled_2739_test
    {
        [Theory, ClassData(typeof(TotalDistanceTraveledTestData))]
        public void Check(int inputData1, int inputData2, int expected)
        {
            var solver = new TotalDistanceTraveled_2739();
            var result = solver.DistanceTraveled(inputData1, inputData2);

            Assert.Equal(expected, result);
        }
    }

    public sealed class TotalDistanceTraveledTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                5,
                10,
                60
            };

            yield return new object[]
            {
                6,
                10,
                70
            };

            yield return new object[]
            {
                7,
                10,
                80
            };

            yield return new object[]
            {
                11,
                20,
                130
            };

            yield return new object[]
            {
                1,
                2,
                10
            };

            yield return new object[]
            {
                9,
                2,
                110
            };

            yield return new object[]
            {
                9,
                0,
                90
            };

            yield return new object[]
            {
                3,
                1,
                30
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
