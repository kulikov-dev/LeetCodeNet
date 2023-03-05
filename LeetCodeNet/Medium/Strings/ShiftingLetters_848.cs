using System.Text;

namespace LeetCodeNet.Medium.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/shifting-letters/
    /// </summary>
    /// <remarks>
    /// You are given a string s of lowercase English letters and an integer array shifts of the same length.
    /// Call the shift() of a letter, the next letter in the alphabet, (wrapping around so that 'z' becomes 'a').
    /// For example, shift('a') = 'b', shift('t') = 'u', and shift('z') = 'a'.
    /// Now for each shifts[i] = x, we want to shift the first i + 1 letters of s, x times.
    /// Return the final string after all such shifts to s are applied.
    /// </remarks>
    public class ShiftingLetters_848
    {
        /// <summary>
        /// Let's assume the straight solution, where we just go through the shifts array and shift chars.
        /// But it's very inefficient, because we need to change the first symbol for N times. Second - for n-1 times
        /// But we can notice, that last char will always shifts for shifts[n] position. The pre-last, for shifts[n] + shifts[n-1]:
        /// This is equivalent to shifting "abc" with shifts=[3 + 5 + 9 , 5 + 9 , 9] == [17 , 14 , 9]
        /// So, we can go in reverse order, from last index to the first and store sum of all indexes, so we can solve it with O(N) time complexity
        /// Good explanation with images is here: https://leetcode.com/problems/shifting-letters/solutions/1451878/c-java-python-easy-solution-well-explained-with-code-for-reference/
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <param name="shifts"> Shifting values </param>
        /// <returns> Shifted string </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public string ShiftingLetters(string s, int[] shifts)
        {
            var sum = 0;
            var sb = new StringBuilder(s);          // Use StringBuilder as it allows to work with strings more efficiency

            for (var i = shifts.Length - 1; i >= 0; i--)
            {
                //// We need to count chars from zero, but 'a' char is starts far away, so some trick here:
                /// By sb[i] - 'a' we will get the index of the char starting from 0
                /// Than we can add SHIFT and use '%' to keep our char in range from 0 to 26
                /// Last step is get the actual (int) of the char in the ASCII table.
                sb[i] = (char)('a' + (sb[i] - 'a' + shifts[i] + sum) % 26);

                sum = (sum + shifts[i]) % 26;       // Store all previous shifts and use '%' dividing to prevent overflow.
            }

            return sb.ToString();
        }
    }
}