using System.Collections;
using LeetCodeNet.Medium.Strings;

namespace LeetCodeNet.Tests.Medium.Strings
{
    public sealed class RemovingStarsFromaString_2390_test
    {
        [Theory, ClassData(typeof(RemovingStarsFromaStringTestData))]
        public void Check(string inputData, string expected)
        {
            var solver = new RemovingStarsFromaString_2390();

            Assert.Equal(expected, solver.RemoveStars(inputData));
        }
    }

    public sealed class RemovingStarsFromaStringTestData : IEnumerable<object[]>
    {
        //// Explanation: Performing the removals from left to right:
        /// - The closest character to the 1st star is 't' in "leet**cod*e". s becomes "lee*cod*e".
        /// - The closest character to the 2nd star is 'e' in "lee*cod*e". s becomes "lecod*e".
        /// - The closest character to the 3rd star is 'd' in "lecod*e". s becomes "lecoe".
        /// There are no more stars, so we return "lecoe".
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "leet**cod*e",
                "lecoe"
            };

            yield return new object[]
            {
                "erase*****",
                string.Empty
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
