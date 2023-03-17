using LeetCodeNet.Easy.LeetMath;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.LeetMath
{
    public sealed class PalindromeNumber_9_test
    {
        [Theory, ClassData(typeof(PalindromeNumberTestData))]
        public void CheckSimple(int inputData, bool expected)
        {
            var solver = new PalindromeNumber_9();

            Assert.Equal(expected, solver.IsPalindrome(inputData));
        }
    }

    public sealed class PalindromeNumberTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: 121 reads as 121 from left to right and from right to left.
            yield return new object[]
            {
               121,
               true
            };

            //// Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
            yield return new object[]
            {
               -121,
               false
            };

            //// Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
            yield return new object[]
            {
               10,
               false
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}