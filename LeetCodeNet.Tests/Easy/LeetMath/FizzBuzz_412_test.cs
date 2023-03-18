using LeetCodeNet.Easy.LeetMath;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.LeetMath
{
    public sealed class FizzBuzz_412_test
    {
        [Theory, ClassData(typeof(FizzBuzzTestData))]
        public void CheckSimple(int inputData, List<string> expected)
        {
            var solver = new FizzBuzz_412();

            Assert.True(Enumerable.SequenceEqual(expected, solver.FizzBuzzSimple(inputData)));
        }

        [Theory, ClassData(typeof(FizzBuzzTestData))]
        public void CheckDelegate(int inputData, List<string> expected)
        {
            var solver = new FizzBuzz_412();

            Assert.True(Enumerable.SequenceEqual(expected, solver.FizzBuzzDelegate(inputData)));
        }
    }

    public sealed class FizzBuzzTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
               3,
               new List<string>{ "1", "2", "Fizz" }
            };

            yield return new object[]
            {
               5,
               new List<string>{ "1", "2", "Fizz", "4", "Buzz" }
            };

            yield return new object[]
            {
               15,
               new List<string>{ "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}