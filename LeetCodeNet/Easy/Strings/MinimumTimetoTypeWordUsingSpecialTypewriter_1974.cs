namespace LeetCodeNet.Easy.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-time-to-type-word-using-special-typewriter/description/
    /// </summary>
    /// <remarks>
    /// There is a special typewriter with lowercase English letters 'a' to 'z' arranged in a circle with a pointer.
    /// A character can only be typed if the pointer is pointing to that character. The pointer is initially pointing to the character 'a'.
    /// </remarks>
    internal sealed class MinimumTimetoTypeWordUsingSpecialTypewriter_1974
    {
        /// <summary>
        /// Native approach. Check the minimum between going clockwise or counterclockwise.
        /// </summary>
        /// <param name="word"> Word </param>
        /// <returns> Count to type </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(1)
        /// </remarks>
        public int MinTimeToType(string word)
        {
            var result = word.Length;       // Time to type each symbol
            var prevChar = 'a';

            for (var i = 0; i < word.Length; i++)
            {
                var ch = word[i];
                var diff = Math.Abs(prevChar - ch);

                result += Math.Min(diff, 26 - diff);

                prevChar = ch;
            }

            return result;
        }
    }
}
