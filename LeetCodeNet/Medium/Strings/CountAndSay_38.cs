using System.Text;

namespace LeetCodeNet.Medium.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/count-and-say/description/
    /// </summary>
    /// <remarks>
    /// The count-and-say sequence is a sequence of digit strings defined by the recursive formula:
    /// countAndSay(1) = "1"
    /// countAndSay(n) is the way you would "say" the digit string from countAndSay(n-1), which is then converted into a different digit string.
    /// </remarks>
    internal sealed class CountAndSay_38
    {
        /// <summary>
        /// The main problem of this problem is to understand the question :)
        /// Here is the example of the n'th element:
        /// 1.     1
        /// 2.     11
        /// 3.     21
        /// 4.     1211
        /// 5.     111221
        /// 6.     312211
        /// 7.     13112221
        /// 8.     1113213211
        /// 9.     31131211131221
        /// 10.    13211311123113112211
        /// </summary>
        /// <param name="n"> Index </param>
        /// <returns> Counted numbers</returns>
        public string CountAndSayRecursive(int n)
        {
            if (n == 1)
            {
                return "1";
            }

            var result = CountAndSayRecursive(n - 1);
            var sb = new StringBuilder(512);

            var indexer = 1;

            for (var i = 1; i < result.Length; i++)
            {
                if (result[i] == result[i - 1])
                {
                    ++indexer;
                }
                else
                {
                    sb.Append(indexer.ToString() + result[i - 1]);
                    indexer = 1;
                }
            }

            return sb.Append(indexer.ToString() + result[result.Length - 1]).ToString();
        }
    }
}
