namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/find-smallest-letter-greater-than-target
    /// </summary>
    /// <remarks>
    /// You are given an array of characters letters that is sorted in non-decreasing order, and a character target. There are at least two different characters in letters.
    /// Return the smallest character in letters that is lexicographically greater than target.If such a character does not exist, return the first character in letters.
    /// </remarks>
    internal sealed class FindSmallestLetterGreaterThanTarget_744
    {
        /// <summary>
        /// Binary search for the character in the alphabets that comes immediately after character target,
        /// or if the target is more than or equal to the last character in the input list, then return the first character in the list.
        /// </summary>
        /// <param name="letters"> Input letters </param>
        /// <param name="target"> Target </param>
        /// <returns> Smallest character greater than target </returns>
        /// <remarks>
        /// Time complexity: O(log n)
        /// Space complexity: O(1)
        /// </remarks>
        public char NextGreatestLetter(char[] letters, char target)
        {
            if (letters[^1] <= target)
            {
                return letters[0];
            }

            var leftIndex = 0;
            var rightIndex = letters.Length - 1;

            while (leftIndex < rightIndex)
            {
                var middleIndex = leftIndex + (rightIndex - leftIndex) / 2;

                if (letters[middleIndex] > target)
                {
                    rightIndex = middleIndex;
                }
                else
                {
                    leftIndex = middleIndex + 1;
                }
            }

            return letters[leftIndex];
        }
    }
}
