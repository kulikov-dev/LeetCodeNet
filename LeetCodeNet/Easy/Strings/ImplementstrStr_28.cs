namespace LeetCodeNet.Easy.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/implement-strstr/
    /// </summary>
    /// <remarks>
    /// Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
    /// </remarks>
    public class ImplementstrStr_28
    {
        /// <summary>
        /// Straight brute force with two loops for haystack and needle.
        /// </summary>
        /// <param name="haystack"> Haystack </param>
        /// <param name="needle"> Needle </param>
        /// <returns> Position of intersection </returns>
        /// <remarks>
        /// Time complexity: O(m * n), haystack.length * needle.length
        /// Space complexity: O(1)
        /// </remarks>
        public int StrStrBruteForceTwoPass(string haystack, string needle)
        {
            if (string.IsNullOrWhiteSpace(needle))
            {
                return 0;
            }

            if (string.IsNullOrWhiteSpace(haystack) || haystack.Length < needle.Length)
            {
                return -1;
            }

            //// One loop throught haystack. Pay attention, that we don't need to iterate, if position of haystack is more than needle.length
            for (var i = 0; i <= haystack.Length - needle.Length; ++i)
            {
                var isValid = true;
                //// Second loop through needle. Check if haystack has needle from i-th position
                for (var j = 0; j < needle.Length; ++j)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// It's not a good idea to use substring on the interview, but if you stuck - showing something is a good approach.
        /// </summary>
        /// <param name="haystack"> Haystack </param>
        /// <param name="needle"> Needle </param>
        /// <returns> Position of intersection </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public int StrStrCheating(string haystack, string needle)
        {
            if (string.IsNullOrWhiteSpace(needle))
            {
                return 0;
            }

            if (string.IsNullOrWhiteSpace(haystack) || haystack.Length < needle.Length)
            {
                return -1;
            }

            for (var i = 0; i <= haystack.Length - needle.Length; ++i)
            {
                if (haystack.Substring(i, needle.Length).Equals(needle))
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Common algorithm for using to detect sub-patterns appearing: Knuth–Morris–Pratt algorithm
        /// The best explanation is here: https://leetcode.com/problems/shortest-palindrome/discuss/60113/clean-kmp-solution-with-super-detailed-explanation#:~:text=The%20key%20of%20KMP%20is,should%20ends%20at%20current%20index.
        /// </summary>
        /// <param name="haystack"> Haystack </param>
        /// <param name="needle"> Needle </param>
        /// <returns> Position of intersection </returns>
        /// <remarks>
        /// Time complexity: O(m + n)
        /// Space complexity: O(m)
        /// </remarks>
        public int StrStrKMP(string haystack, string needle)
        {
            if (string.IsNullOrWhiteSpace(needle))
            {
                return 0;
            }

            if (string.IsNullOrWhiteSpace(haystack) || haystack.Length < needle.Length)
            {
                return -1;
            }

            var preprocessedInfo = PreprocessKMP(needle);
            var haystackPos = 0;
            var needlePos = 0;
            while (haystackPos < haystack.Length && needlePos < needle.Length)
            {
                if (haystack[haystackPos] == needle[needlePos])
                {
                    haystackPos++;
                    needlePos++;
                }
                else if (needlePos > 0)
                {
                    needlePos = preprocessedInfo[needlePos - 1];
                }
                else
                {
                    haystackPos++;
                }
            }

            return needlePos == needle.Length ? haystackPos - needlePos : -1;
        }

        /// <summary>
        /// Pattern preprocessing for KMP
        /// </summary>
        /// <param name="pattern"> Pattern </param>
        /// <returns> Preprocessed indexes </returns>
        private int[] PreprocessKMP(string pattern)
        {
            var i = 1;
            var j = 0;
            var res = new int[pattern.Length];
            while (i < pattern.Length)
            {
                if (pattern[i] == pattern[j])
                {
                    res[i] = j + 1;
                    i++;
                    j++;
                }
                else if (j > 0)
                {
                    j = res[j - 1];
                }
                else
                {
                    res[i] = 0;
                    i++;
                }
            }

            return res;
        }
    }
}