using LeetCodeNet.Easy.Strings;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Strings
{
    public sealed class ValidPalindrome_125_test
    {
        [Theory, ClassData(typeof(ValidPalindromeTestData))]
        public void CheckLinqMethod(string inputData, bool expected)
        {
            var solver = new ValidPalindrome_125();

            Assert.Equal(expected, solver.IsPalindromeLinq(inputData));
        }

        [Theory, ClassData(typeof(ValidPalindromeTestData))]
        public void CheckPointersMethod(string inputData, bool expected)
        {
            var solver = new ValidPalindrome_125();

            Assert.Equal(expected, solver.IsPalindromePointers(inputData));
        }
    }

    public sealed class ValidPalindromeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: "amanaplanacanalpanama" is a palindrome.
            yield return new object[]
            {
                "A man, a plan, a canal: Panama",
                true
            };

            //// Explanation: "raceacar" is not a palindrome.
            yield return new object[]
            {
                "race a car",
                false
            };

            yield return new object[]
            {
                "   ",
                true
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
