using System.Collections;
using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class Finding3_DigitEvenNumbers_2094_test
    {
        [Theory, ClassData(typeof(Finding3_DigitEvenNumbersTestData))]
        public void CheckNotOptimal(int[] inputData, int[] expected)
        {
            var solver = new Finding3_DigitEvenNumbers_2094();
            var result = solver.FindEvenNumbersNotOptimal(inputData);
            Assert.True(expected.SequenceEqual(result));
        }

        [Theory, ClassData(typeof(Finding3_DigitEvenNumbersTestData))]
        public void CheckOptimal(int[] inputData, int[] expected)
        {
            var solver = new Finding3_DigitEvenNumbers_2094();
            var result = solver.FindEvenNumbersOptimal(inputData);
            Assert.True(expected.SequenceEqual(result));
        }
    }

    public sealed class Finding3_DigitEvenNumbersTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: All the possible integers that follow the requirements are in the output array. 
            /// Notice that there are no odd integers or integers with leading zeros.
            yield return new object[]
            {
                new []{2,1,3,0},
                new []{102,120,130,132,210,230,302,310,312,320},
            };

            //// Explanation: The same digit can be used as many times as it appears in digits.
            /// In this example, the digit 8 is used twice each time in 288, 828, and 882.
            yield return new object[]
            {
                new []{2,2,8,8,2},
                new []{222,228,282,288,822,828,882},
            };

            yield return new object[]
            {
                new []{3,7,5},
                System.Array.Empty<int>()
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
