using LeetCodeNet.Easy.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Array
{
    public class AverageSalaryExcludingtheMinimumandMaximumSalary_1491_test
    {
        [Theory, ClassData(typeof(AverageSalaryExcludingtheMinimumandMaximumSalaryTestData))]
        public void CheckLinq(int[] inputData, double expected)
        {
            var solver = new AverageSalaryExcludingtheMinimumandMaximumSalary_1491();
            Assert.Equal(expected, Math.Round(solver.AverageLinq(inputData),3));
        }

        [Theory, ClassData(typeof(AverageSalaryExcludingtheMinimumandMaximumSalaryTestData))]
        public void CheckSorting(int[] inputData, double expected)
        {
            var solver = new AverageSalaryExcludingtheMinimumandMaximumSalary_1491();
            Assert.Equal(expected, Math.Round(solver.AverageSorting(inputData), 3));
        }

        [Theory, ClassData(typeof(AverageSalaryExcludingtheMinimumandMaximumSalaryTestData))]
        public void CheckIterating(int[] inputData, double expected)
        {
            var solver = new AverageSalaryExcludingtheMinimumandMaximumSalary_1491();
            Assert.Equal(expected, Math.Round(solver.AverageIterating(inputData), 3));
        }
    }

    public class AverageSalaryExcludingtheMinimumandMaximumSalaryTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: Minimum salary and maximum salary are 1000 and 4000 respectively.
            /// Average salary excluding minimum and maximum salary is (2000 + 3000) / 2 = 2500
            yield return new object[]
            {
                new int[] { 4000, 3000, 1000, 2000 },
                2500d
            };

            yield return new object[]
            {
                new int[] { 1000, 2000, 3000 },
                2000d
            };

            yield return new object[]
            {
                new int[] { 48000, 59000, 99000, 13000, 78000, 45000, 31000, 17000, 39000, 37000, 93000, 77000, 33000, 28000, 4000, 54000, 67000, 6000, 1000, 11000 },
                41111.111d
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}