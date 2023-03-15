namespace LeetCodeNet.Medium.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/optimal-partition-of-string
    /// </summary>
    /// <remarks>
    /// Given a string s, partition the string into one or more substrings such that the characters in each substring are unique. That is, no letter appears in a single substring more than once.
    /// Return the minimum number of substrings in such a partition.
    /// </remarks>
    public sealed class OptimalPartitionofString_2405
    {
        /// <summary>
        /// The first thing that comes to my mind was: "use hash"!
        /// So, we just iterating through the string, char by char. If any of char in the hash - increment the result and reset the hash.
        /// Simple and elegant
        /// </summary>
        /// <param name="s"> String </param>
        /// <returns> Number of unique strings </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(1), not more as we just need to keep for 26 symbols
        /// </remarks>
        public int PartitionStringHash(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }

            var result = 0;
            var chHash = new HashSet<char>();

            foreach (var ch in s)
            {
                if (!chHash.Add(ch))
                {
                    ++result;
                    chHash.Clear();
                    chHash.Add(ch);
                }
            }

            return result + 1;
        }

        /// <summary>
        /// If we don't have hashset - we can use a bool array, where each element represents the char.
        /// It's not very elegant as we need to reset array each time, when the duplicate char meets
        /// </summary>
        /// <param name="s"> String </param>
        /// <returns></returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(1), but it still the same time complexity
        /// </remarks>
        public int PartitionStringArr(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }

            var result = 0;
            var chArray = new bool[32];
            foreach (var ch in s)
            {
                if (chArray[ch - 'a'])
                {
                    ++result;
                    chArray = new bool[32];
                }

                chArray[ch - 'a'] = true;
            }

            return result + 1;
        }

        /// <summary>
        /// Advanced level is to use bit manipulations. To check if a char is repeated or not bit wise operator used, each bit of flag represents a char.
        /// </summary>
        /// <param name="s"> String </param>
        /// <returns></returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(1)
        /// </remarks>
        public int PartitionStringBit(string s)
        {
            var result = 0;
            var bit = 0;

            foreach (var ch in s)
            {
                var num = ch - 'a';     // get the real position of the char in the alphabet

                if ((bit & (1 << num)) > 0)     // for example 1000 represents 'd' we need to get the flag on this position, so we use & operator to leave only this flag.
                {
                    bit = 0;

                    ++result;
                }

                bit |= 1 << num;
            }

            return result + 1;
        }

    }
}
