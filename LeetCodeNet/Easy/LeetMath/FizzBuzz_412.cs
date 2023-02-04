using System.Text;

namespace LeetCodeNet.Easy.LeetMath
{
    /// <summary>
    /// https://leetcode.com/problems/fizz-buzz/
    /// </summary>
    /// <remarks>
    /// Given an integer n, return a string array answer (1-indexed) where:
    /// answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
    /// answer[i] == "Fizz" if i is divisible by 3.
    /// answer[i] == "Buzz" if i is divisible by 5.
    /// answer[i] == i(as a string) if none of the above conditions are true.
    /// </remarks>
    public sealed class FizzBuzz_412
    {
        /// <summary>
        /// Simple plain solution
        /// </summary>
        /// <param name="n"> Count </param>
        /// <returns> FizzBuzz string </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public IList<string> FizzBuzzSimple(int n)
        {
            var result = new List<string>();
            for (var i = 1; i <= n; ++i)
            {
                var sb = new StringBuilder();
                if (i % 3 == 0)
                {
                    sb.Append("Fizz");
                }

                if (i % 5 == 0)
                {
                    sb.Append("Buzz");
                }

                result.Add(sb.Length == 0 ? i.ToString() : sb.ToString());
            }

            return result;
        }

        /// <summary>
        /// More elegant solution. In case if we have > 10 variants of conditions, it will show to the interviewer better approach to deal with it
        /// </summary>
        /// <param name="n"> Count </param>
        /// <returns> FizzBuzz string </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public IList<string> FizzBuzzDelegate(int n)
        {
            var rules = new List<Func<int, string>>
            {
                (target) => { return target % 15 == 0 ? "FizzBuzz" : string.Empty; },
                (target) => { return target % 5 == 0 ? "Buzz" : string.Empty; },
                (target) => { return target % 3 == 0 ? "Fizz" : string.Empty; }
            };

            var result = new List<string>();
            for (var i = 1; i <= n; ++i)
            {
                var temp = rules.Select(rule => rule.Invoke(i)).FirstOrDefault(ruleResult => !string.IsNullOrWhiteSpace(ruleResult));

                result.Add(temp ?? i.ToString());
            }

            return result;
        }

    }
}