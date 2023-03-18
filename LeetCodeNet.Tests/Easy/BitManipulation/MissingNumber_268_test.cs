using System.Collections;
using LeetCodeNet.Easy.BitManipulation;

namespace LeetCodeNet.Tests.Easy.BitManipulation
{
    public sealed class MissingNumber_268_test
    {
        [Theory, ClassData(typeof(MissingNumberTestData))]
        public void CheckSimple(int[] inputData1, int expected)
        {
            var solver = new MissingNumber_268();
            var result = solver.MissingNumberSimple(inputData1);

            Assert.Equal(expected, result);
        }

        [Theory, ClassData(typeof(MissingNumberTestData))]
        public void CheckMath(int[] inputData1, int expected)
        {
            var solver = new MissingNumber_268();
            var result = solver.MissingNumberMath(inputData1);

            Assert.Equal(expected, result);
        }

        [Theory, ClassData(typeof(MissingNumberTestData))]
        public void CheckBit(int[] inputData1, int expected)
        {
            var solver = new MissingNumber_268();
            var result = solver.MissingNumberBit(inputData1);

            Assert.Equal(expected, result);
        }
    }

    public sealed class MissingNumberTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: n = 3 since there are 3 numbers, so all numbers are in the range [0,3]. 2 is the missing number in the range since it does not appear in nums.
            yield return new object[]
            {
                new []{3,0,1},
                2
            };

            //// Explanation: n = 2 since there are 2 numbers, so all numbers are in the range [0,2]. 2 is the missing number in the range since it does not appear in nums.
            yield return new object[]
            {
                new []{0,1},
                2
            };

            //// Explanation: n = 9 since there are 9 numbers, so all numbers are in the range [0,9]. 8 is the missing number in the range since it does not appear in nums.
            yield return new object[]
            {
                new[] { 9,6,4,2,3,5,7,0,1 },
                8
            };
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
