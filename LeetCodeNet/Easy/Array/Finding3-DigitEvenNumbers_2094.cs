
namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/finding-3-digit-even-numbers/
    /// </summary>
    public sealed class Finding3_DigitEvenNumbers_2094
    {
        /// <summary>
        /// First thought that came to my mind was backtracking. We can try to find all combinations in digits and check if this combination allowed
        /// This solution passed the test, however it's not very optimal.
        /// </summary>
        /// <param name="digits"> Digits </param>
        /// <returns> 3 Digit even numbers </returns>
        /// <remarks>
        /// Time complexity: O(N!)
        /// Space complexity: O(N!)
        /// </remarks>
        public int[] FindEvenNumbersNotOptimal(int[] digits)
        {
            var digit = new List<int>();
            var result = new List<int>();

            Recursive(digits, digit, new HashSet<int>(), ref result);

            return result.OrderBy(x => x).Distinct().ToArray();
        }

        /// <summary>
        /// Recursive function for backtracking
        /// </summary>
        /// <param name="digits"> Input array </param>
        /// <param name="digit"> Current digit </param>
        /// <param name="usedPos"> Hashset of used digits (store positions) </param>
        /// <param name="result">3 digit even numbers </param>
        private void Recursive(int[] digits, List<int> digit, HashSet<int> usedPos, ref List<int> result)
        {
            if (digit.Count == 3)
            {
                var number = Convert(digit);
                if (number % 2 == 0)
                {
                    result.Add(number);
                }

                return;
            }

            for (var i = 0; i < digits.Length; i++)
            {
                if (digit.Count == 0 && digits[i] == 0)
                {
                    continue;
                }

                if (!usedPos.Add(i))
                {
                    continue;
                }

                digit.Add(digits[i]);
                Recursive(digits, digit, usedPos, ref result);
                digit.RemoveAt(digit.Count - 1);

                usedPos.Remove(i);
            }
        }

        /// <summary>
        /// Convert digit in array representation to the number
        /// </summary>
        /// <param name="digit"> Array digit </param>
        /// <returns> Number digit </returns>
        private int Convert(List<int> digit)
        {
            var result = 0;
            foreach (var i in digit)
            {
                result = result * 10 + i;
            }

            return result;
        }

        /// <summary>
        /// Instead of backtracking we can use hash to store all used digits and just check if we have enough digits to build the current number
        /// </summary>
        /// <param name="digits"></param>
        /// <returns> 3 Digit even numbers </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public int[] FindEvenNumbersOptimal(int[] digits)
        {
            var result = new List<int>();
            var hash = Enumerable.Repeat(0, 10).ToArray();
            foreach (var digit in digits)
            {
                hash[digit]++;
            }

            for (var i = 100; i <= 999; i += 2)         // Use increment for 2 to get only even numbers
            {
                var curDigits = Enumerable.Repeat(0, 10).ToArray();
                var number = i;
                while (number != 0)
                {
                    curDigits[number % 10]++;
                    number /= 10;
                }

                var isBad = false;
                for (var j = 0; j < curDigits.Length; ++j)
                {
                    if (hash[j] < curDigits[j])
                    {
                        isBad = true;
                        break;
                    }
                }

                if (!isBad)
                {
                    result.Add(i);
                }
            }

            return result.ToArray();
        }

    }
}
