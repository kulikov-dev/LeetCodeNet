namespace LeetCodeNet.Medium.Array
{
    /// <summary>
    /// https://leetcode.com/problems/bulls-and-cows
    /// </summary>
    /// <remarks>
    /// You are playing the Bulls and Cows game with your friend.
    /// You write down a secret number and ask your friend to guess what the number is. When your friend makes a guess, you provide a hint with the following info:
    /// The number of "bulls", which are digits in the guess that are in the correct position.
    /// The number of "cows", which are digits in the guess that are in your secret number but are located in the wrong position.Specifically, the non-bull digits in the guess that could be rearranged such that they become bulls.
    /// Given the secret number secret and your friend's guess guess, return the hint for your friend's guess.
    /// The hint should be formatted as "xAyB", where x is the number of bulls and y is the number of cows. Note that both secret and guess may contain duplicate digits.
    /// </remarks>
    internal sealed class BullsandCows_299
    {
        /// <summary>
        /// The idea is to create numbers array to store amount of num digits in the secret
        /// In the first loop we calc all different numbers in the secret
        /// In the second loop we calc bulls for the equal digits and cows for digits, which we already have
        /// </summary>
        /// <param name="secret"> Secret </param>
        /// <param name="guess"> Guess </param>
        /// <returns> Hint </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(1)
        /// </remarks>
        public string GetHintTwoPassCommon(string secret, string guess)
        {
            var bulls = 0;
            var cows = 0;

            var temp = new int[10];

            for (var i = 0; i < secret.Length; ++i)
            {
                if (secret[i] - '0' != guess[i] - '0')
                {
                    temp[secret[i] - '0']++;
                }
            }

            for (var i = 0; i < secret.Length; ++i)
            {
                if (secret[i] - '0' == guess[i] - '0')
                {
                    ++bulls;
                }
                else if (temp[guess[i] - '0'] > 0)
                {
                    ++cows;
                    temp[guess[i] - '0']--;
                }
            }

            return $"{bulls}A{cows}B";
        }

        /// <summary>
        /// Slight optimized solution with two passes. The same idea.
        /// </summary>
        /// <param name="secret"> Secret </param>
        /// <param name="guess"> Guess </param>
        /// <returns> Hint </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(1)
        /// </remarks>
        public string GetHintTwoPassOptimized(string secret, string guess)
        {
            var bulls = 0;
            var cows = 0;

            var secretArr = new int[10];
            var guessArr = new int[10];

            for (var i = 0; i < secret.Length; ++i)
            {
                if (secret[i] - '0' == guess[i] - '0')
                {
                    ++bulls;
                }
                else
                {
                    secretArr[secret[i] - '0']++;
                    guessArr[guess[i] - '0']++;
                }
            }

            for (var i = 0; i < secretArr.Length; ++i)
            {
                cows += Math.Min(secretArr[i], guessArr[i]);
            }

            return $"{bulls}A{cows}B";
        }

        /// <summary>
        /// Finally we can come to one pass solution with one numbers array.
        /// We store information about all strings in the one array.
        /// </summary>
        /// <param name="secret"> Secret </param>
        /// <param name="guess"> Guess </param>
        /// <returns> Hint </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(1)
        /// </remarks>
        public string GetHintOnePass(string secret, string guess)
        {
            var bulls = 0;
            var cows = 0;

            var numbers = new int[10];

            for (var i = 0; i < secret.Length; ++i)
            {
                var secretNum = secret[i] - '0';
                var guessNum = guess[i] - '0';

                if (secretNum == guessNum)
                {
                    ++bulls;
                }
                else
                {
                    if (numbers[secretNum] < 0)
                    {
                        ++cows;
                    }

                    if (numbers[guessNum] > 0)
                    {
                        ++cows;
                    }

                    numbers[secretNum]++;
                    numbers[guessNum]--;
                }
            }

            return $"{bulls}A{cows}B";
        }
    }
}
