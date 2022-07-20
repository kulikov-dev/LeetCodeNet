namespace LeetCodeNet.Easy.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/verifying-an-alien-dictionary/
    /// </summary>
    public class VerifyinganAlienDictionary_953
    {
        /// <summary>
        /// Key points is to:
        /// 1. Use hash table to store char's order for easy access. 
        /// 2. Compare words by pairs, no need to bother about comparing all words at once.
        /// </summary>
        /// <param name="words"> Words to compare </param>
        /// <param name="order"> Custom alphabet orders </param>
        /// <returns> Flag if words  sorted </returns>
        /// <remarks>
        /// Time complexity: O(n * m), for words count as N and the max word length as M
        /// Space complexity: O(1)
        /// </remarks>
        public bool IsAlienSorted(string[] words, string order)
        {
            //// Hash table to store mapping char and it's position in the alien alphabet
            var dictOrder = new Dictionary<char, int>();
            for (var i = 0; i < order.Length; ++i)
            {
                dictOrder.Add(order[i], i);
            }

            for (var i = 1; i < words.Length; ++i)
            {
                if (!IsWordsSorted(words[i - 1], words[i], dictOrder))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Check if two words sorted by the mapper order
        /// </summary>
        /// <param name="word1"> Word 1 </param>
        /// <param name="word2"> Word 2 </param>
        /// <param name="mapper"> Alphabet info </param>
        /// <returns> Flag, if words sorted </returns>
        private bool IsWordsSorted(string word1, string word2, Dictionary<char, int> mapper)
        {
            //// Lexicographicall sorted when:
            /// 1. At first mismatch word1[char] < word2[char]
            /// 2. If all letters match, when length(word1) < length(word2)

            var maxLength = Math.Min(word1.Length, word2.Length);
            for (var i = 0; i < maxLength; ++i)
            {
                //// Check two words, char by char. If char is different - we can use mapper to compare chars
                if (word1[i] != word2[i])
                {
                    return mapper[word1[i]] <= mapper[word2[i]];
                }
            }

            //// If two words a different - we can check by it's length
            if (word1.Length > word2.Length)
            {
                return false;
            }

            return true;
        }
    }
}