using LeetCodeNet.Easy.DP;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.DP
{
    public sealed class FibonacciNumber_509_test
    {
        [Theory, ClassData(typeof(FibonacciNumberTestData))]
        public void CheckRecursive(int inputData, int expected)
        {
            var solver = new FibonacciNumber_509();

            Assert.Equal(expected, solver.FibRecursive(inputData));
        }

        [Theory, ClassData(typeof(FibonacciNumberTestData))]
        public void CheckDp1(int inputData, int expected)
        {
            var solver = new FibonacciNumber_509();

            Assert.Equal(expected, solver.FibDp1(inputData));
        }

         [Theory, ClassData(typeof(FibonacciNumberTestData))]
         public void CheckDp2(int inputData, int expected)
         {
             var solver = new FibonacciNumber_509();

             Assert.Equal(expected, solver.FibDp2(inputData));
         }
    }

    public sealed class FibonacciNumberTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                2,
                1
            };

            yield return new object[]
            {
                3,
                2
            };

            yield return new object[]
            {
                4,
                3
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
