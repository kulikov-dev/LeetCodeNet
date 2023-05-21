using System.Collections;
using LeetCodeNet.Medium.DP;

namespace LeetCodeNet.Tests.Medium.DP
{
    public sealed class FindthePunishmentNumberofanInteger_2698_test
    {
        [Theory, ClassData(typeof(FindthePunishmentNumberofanIntegerTestData))]
        public void Check(int inputData, int expected)
        {
            var solver = new FindthePunishmentNumberofanInteger_2698();
            var result = solver.PunishmentNumber(inputData);

            Assert.Equal(expected, result);
        }
    }

    public sealed class FindthePunishmentNumberofanIntegerTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                10,
                182
            };

            yield return new object[]
            {
                37,
                1478
            };

            yield return new object[]
            {
                1,
                1
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
