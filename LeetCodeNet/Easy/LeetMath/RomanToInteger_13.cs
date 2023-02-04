namespace LeetCodeNet.Easy.LeetMath
{
    /// <summary>
    /// https://leetcode.com/problems/roman-to-integer/
    /// </summary>
    /// <remarks> Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
    /// For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.
    /// </remarks>
    public sealed class RomanToInteger_13
    {
        /// <summary>
        /// Store dictionary with all possible roman values converted to arabian numbers.
        /// We go from right to left and add values to result number.
        /// If previous number is bigger than current - it's situation where we need to subtract value, like IV..
        /// </summary>
        /// <param name="inputStr"> Roman number </param>
        /// <returns> Flag, if progression </returns>
        /// <remarks>
        /// Time complexity: O(1)
        /// Space complexity: O(1)
        /// </remarks>
        public int RomanToInt(string inputStr)
        {
            var romanDict = new Dictionary<char, int> { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };
            var result = 0;
            var prevValue = 0;

            for (var i = inputStr.Length - 1; i >= 0; --i)
            {
                var currentChar = inputStr[i];
                var currentValue = romanDict[currentChar];

                if (currentValue < prevValue)
                {
                    result -= currentValue;
                }
                else
                {
                    result += currentValue;
                }

                prevValue = currentValue;
            }

            return result;
        }
    }
}
