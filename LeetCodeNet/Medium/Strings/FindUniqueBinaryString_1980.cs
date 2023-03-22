using System.Text;

namespace LeetCodeNet.Medium.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/find-unique-binary-string/
    /// </summary>
    /// <remarks> Given an array of strings nums containing n unique binary strings each of length n, return a binary string of length n that does not appear in nums. If there are multiple answers, you may return any of them. </remarks>
    internal sealed class FindUniqueBinaryString_1980
    {
        /// <summary>
        /// Straight solution with some optimization. Just to show something to your interviewer
        /// </summary>
        /// <param name="nums"> Input nums </param>
        /// <returns> Missing nums </returns>
        /// <remarks>
        /// Time complexity: O(n^2)
        /// Space complexity: O(n)
        /// </remarks>
        public string FindDifferentBinaryStringBruteForce(string[] nums)
        {
            var possibleVariants = new List<string>();

            var length = nums[0].Length;
            var sb = new StringBuilder(string.Join(string.Empty, Enumerable.Repeat(0, length)));

            for (var i = 0; i < length; i++)
            {
                var hasZero = false;
                var hasOne = false;

                foreach (var num in nums)
                {
                    if (num[i] == '0')
                    {
                        hasZero = true;
                    }
                    else
                    {
                        hasOne = true;
                    }

                    if (hasZero && hasOne)
                    {
                        break;
                    }
                }

                if (hasZero && !hasOne)
                {
                    sb[i] = '1';

                    return sb.ToString();
                }

                if (!hasZero && hasOne)
                {
                    return sb.ToString();
                }

                possibleVariants.Add(sb.ToString());

                sb[i] = '1';

                possibleVariants.Add(sb.ToString());
            }

            return possibleVariants.First(x => !nums.Contains(x));
        }

        /// <summary>
        /// Better solution is based on the Cantor theorem.
        /// We know that the number of bits in the number equals the number of elements.
        /// What we can do is create a binary string with the first binary in the first position, the second binary in the second position, the third binary in the third position, and so on.
        /// This will ensure that the binary we created is unique (as it differs from all others at atleast one position).
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public string FindDifferentBinaryStringCantor(string[] nums)
        {
            var sb = new StringBuilder(nums.Length);

            for (var i = 0; i < nums.Length; i++)
            {
                sb.Append(nums[i][i] == '0' ? '1' : '0');
            }

            return sb.ToString();
        }
    }
}