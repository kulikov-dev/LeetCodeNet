namespace LeetCodeNet.Easy.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-string/
    /// </summary>
    /// <remarks>
    /// Write a function that reverses a string. The input string is given as an array of characters s.
    /// You must do this by modifying the input array in-place with O(1) extra memory.
    /// </remarks>
    public class ReverseString_344
    {
        /// <summary>
        /// Two pointers approach. One pointer is pointing at the start of the string, another - at the end. Swapping each element and change pointers position
        /// </summary>
        /// <param name="s"> Input string in char array </param>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public void ReverseString(char[] s)
        {
            var leftPointer = 0;
            var rightPointer = s.Length - 1;
            while (leftPointer < rightPointer)
            {
                var temp = s[leftPointer];
                s[leftPointer] = s[rightPointer];
                s[rightPointer] = temp;

                ++leftPointer;
                --rightPointer;
            }
        }
    }
}
