using System.Collections;
using LeetCodeNet.Medium.Strings;

namespace LeetCodeNet.Tests.Medium.Strings
{
    public sealed class OptimalPartitionofString_2405_test
    {
        [Theory, ClassData(typeof(OptimalPartitionofStringTestData))]
        public void CheckArr(string inputData, int expected)
        {
            var solver = new OptimalPartitionofString_2405();

            Assert.Equal(expected, solver.PartitionStringArr(inputData));
        }

        [Theory, ClassData(typeof(OptimalPartitionofStringTestData))]
        public void CheckHash(string inputData, int expected)
        {
            var solver = new OptimalPartitionofString_2405();

            Assert.Equal(expected, solver.PartitionStringHash(inputData));
        }

        [Theory, ClassData(typeof(OptimalPartitionofStringTestData))]
        public void CheckBit(string inputData, int expected)
        {
            var solver = new OptimalPartitionofString_2405();

            Assert.Equal(expected, solver.PartitionStringBit(inputData));
        }
    }

    public sealed class OptimalPartitionofStringTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation:
            /// Two possible partitions are("a","ba","cab","a") and("ab", "a", "ca", "ba").
            /// It can be shown that 4 is the minimum number of substrings needed.
            yield return new object[]
            {
                "abacaba",
                4
            };

            //// The only valid partition is ("s","s","s","s","s","s").
            yield return new object[]
            {
                "ssssss",
                6
            };

            yield return new object[]
            {
                "hdklqkcssgxlvehva",
                4
            };
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
