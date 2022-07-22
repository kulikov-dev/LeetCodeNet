namespace LeetCodeNet.Easy.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/ransom-note/
    /// </summary>
    /// <remarks>
    /// Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.
    /// Each letter in magazine can only be used once in ransomNote.
    /// </remarks>
    public class RansomNote_383
    {
        /// <summary>
        /// The common solution is to create hashtable to store all chars/counts from the magazine
        /// </summary>
        /// <param name="ransomNote"> Constructed string </param>
        /// <param name="magazine"> Source string </param>
        /// <returns> Flag if constructed created from source </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public bool CanConstructHash(string ransomNote, string magazine)
        {
            var dict = new Dictionary<char, int>();
            for (var i = 0; i < magazine.Length; ++i)
            {
                var ch = magazine[i];
                if (!dict.ContainsKey(ch))
                {
                    dict.Add(ch, 0);
                }

                ++dict[ch];
            }

            for (var i = 0; i < ransomNote.Length; ++i)
            {
                var ch = ransomNote[i];
                if (!dict.ContainsKey(ch) || dict[ch] == 0)
                {
                    return false;
                }

                --dict[ch];
            }

            return true;
        }

        /// <summary>
        /// The more interesting solution is to use array for each char in alphabet.
        /// </summary>
        /// <param name="ransomNote"> Constructed string </param>
        /// <param name="magazine"> Source string </param>
        /// <returns> Flag if constructed created from source </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public bool CanConstructArray(string ransomNote, string magazine)
        {
            var arr = new int[26];
            for (var  i =0; i < magazine.Length; ++i)
            {
                //// Char manipulation on ASCII codes. As 'a' = 97 in ASCII, so we need to substract 'a' to get the real position in alphabet
                ++arr[magazine[i] - 'a'];
            }

            for (var i = 0; i < ransomNote.Length; ++i)
            {
                var pos = ransomNote[i] - 'a';
                --arr[pos];
                if (arr[pos] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}