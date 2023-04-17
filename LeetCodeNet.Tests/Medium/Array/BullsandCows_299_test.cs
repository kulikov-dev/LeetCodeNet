using LeetCodeNet.Medium.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Medium.Array
{
    public sealed class BullsandCows_299_test
    {
        [Theory, ClassData(typeof(BullsandCowsTestData))]
        public void CheckTwoPass(string input1, string input2, string expected)
        {
            var solver = new BullsandCows_299();

            Assert.Equal(expected, solver.GetHintTwoPassCommon(input1, input2));
        }

        [Theory, ClassData(typeof(BullsandCowsTestData))]
        public void CheckTwoPassOptimized(string input1, string input2, string expected)
        {
            var solver = new BullsandCows_299();

            Assert.Equal(expected, solver.GetHintTwoPassOptimized(input1, input2));
        }

        [Theory, ClassData(typeof(BullsandCowsTestData))]
        public void CheckOnePass(string input1, string input2, string expected)
        {
            var solver = new BullsandCows_299();

            Assert.Equal(expected, solver.GetHintOnePass(input1, input2));
        }
    }

    public sealed class BullsandCowsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "1807",
                "7810",
                "1A3B"
            };

            yield return new object[]
            {
                "1123",
                "0111",
                "1A1B"
            };

            yield return new object[]
            {
                "1122",
                "1222",
                "3A0B"
            };

            yield return new object[]
            {
                "11",
                "10",
                "1A0B"
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
