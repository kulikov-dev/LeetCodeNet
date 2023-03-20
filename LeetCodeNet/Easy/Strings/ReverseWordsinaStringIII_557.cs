
namespace LeetCodeNet.Easy.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-words-in-a-string-iii/
    /// </summary>
    /// <remarks> Given a string s, reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order. </remarks>
    internal sealed class ReverseWordsinaStringIII_557
    {
        /// <summary>
        /// The easiest solution is to use LINQ for solving. By lines:
        /// 1. We need to split our string to separate words
        /// 2. Reverse each word using LINQ
        /// 3. Combine words to string again
        /// </summary>
        /// <param name="s"> String </param>
        /// <returns> Reversed string </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public string ReverseWordsLinq(string s)
        {
            var words = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var reversedWords = words.Select(x => new string(x.Reverse().ToArray()));

            return string.Join(' ', reversedWords);
        }

        /// <summary>
        /// Idea is to use pointers for word detections. As we have indexes of each word - we can create new reversed word by function 'ReverseWord
        /// </summary>
        /// <param name="s"> String </param>
        /// <returns> Reversed string </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public string ReverseStringTwoPointers(string s)
        {
            var result = new List<string>();
            var startWordIndex = 0;

            for (var i = 0; i < s.Length; ++i)
            {
                //// The space shows us, that new word is starting.
                if (s[i] == ' ')
                {
                    int endWordIndex = i - 1;

                    result.Add(ReverseWord(s, startWordIndex, endWordIndex));
                    startWordIndex = i + 1;
                }
            }

            //// Don't forget to reverse last word in the string.
            result.Add(ReverseWord(s, startWordIndex, s.Length - 1));
            return string.Join(' ', result);
        }

        /// <summary>
        /// Reverse word
        /// </summary>
        /// <param name="s"> String </param>
        /// <param name="startWordIndex"> Start word index </param>
        /// <param name="endWordIndex"> End word index </param>
        /// <returns> Reversed word </returns>
        private string ReverseWord(string s, int startWordIndex, int endWordIndex)
        {
            //// We will work with char array to avoid working with strings directly
            var word = new char[endWordIndex - startWordIndex + 1];
            var pointer = 0;

            for (var i = endWordIndex; i >= startWordIndex; --i)
            {
                word[pointer++] = s[i];
            }

            //// Return char array as a string
            return new string(word);
        }
    }
}
