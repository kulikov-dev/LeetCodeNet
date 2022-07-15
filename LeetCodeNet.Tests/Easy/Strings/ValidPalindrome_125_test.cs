using LeetCodeNet.Easy.Strings;

namespace LeetCodeNet.Tests.Easy.Strings
{
    public class ValidPalindrome_125_test
    {
        [Fact]
        public void CheckLinqMethod()
        {
            var solver = new ValidPalindrome_125();
            //// Explanation: "amanaplanacanalpanama" is a palindrome.
            Assert.True(solver.IsPalindromeLinq("A man, a plan, a canal: Panama"));
            //// Explanation: "raceacar" is not a palindrome.
            Assert.False(solver.IsPalindromeLinq("race a car"));
            Assert.True(solver.IsPalindromeLinq("   "));
        }

        [Fact]
        public void CheckPointersMethod()
        {
            var solver = new ValidPalindrome_125();
            //// Explanation: "amanaplanacanalpanama" is a palindrome.
            Assert.True(solver.IsPalindromePointers("A man, a plan, a canal: Panama"));
            //// Explanation: "raceacar" is not a palindrome.
            Assert.False(solver.IsPalindromePointers("race a car"));
            Assert.True(solver.IsPalindromePointers("   "));
        }
    }
}
