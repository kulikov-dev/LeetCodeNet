using System.Text;

namespace LeetCodeNet.Easy.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-vowels-of-a-string/
    /// </summary>
    /// <remarks>
    /// Given a string s, reverse only all the vowels in the string and return it.
    /// The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.
    /// </remarks>
    internal sealed class ReverseVowelsofaString_345
    {
        /// <summary>
        /// First approach is to use queue to store all vowels. And then restore in the reverse order using stringbuilder
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <returns> Reversed vowels string </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public string ReverseVowelsTwoPass(string s)
        {
            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            var queue = new Queue<char>();

            for (var i = 0; i < s.Length; i++)
            {
                if (vowels.Contains(s[i]))
                {
                    queue.Enqueue(s[i]);
                }
            }

            var result = new StringBuilder(s);

            for (var i = s.Length-1; i >= 0; --i)
            {
                if (vowels.Contains(s[i]))
                {
                    result[i] = queue.Dequeue();
                }
            }

            return result.ToString();
        }

        /// <summary>
        /// Second approach is to use two-pointers approach. Left pointer for the start vowels, right - for the end vowels.
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <returns> Reversed vowels string </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public string ReverseVowelsTwoPointers(string s)
        {
            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            var result = new StringBuilder(s);

            var leftPointer = 0;
            var rightPointer = s.Length - 1;

            while (leftPointer < rightPointer)
            {
                while (!vowels.Contains(result[leftPointer]) && leftPointer < rightPointer)
                {
                    ++leftPointer;
                }

                while (!vowels.Contains(result[rightPointer]) && leftPointer < rightPointer)
                {
                    --rightPointer;
                }

                //// Sintax sugar for swap 
                (result[rightPointer], result[leftPointer]) = (result[leftPointer], result[rightPointer]);

                ++leftPointer;
                --rightPointer;
            }

            return result.ToString();
        }
    }
}
