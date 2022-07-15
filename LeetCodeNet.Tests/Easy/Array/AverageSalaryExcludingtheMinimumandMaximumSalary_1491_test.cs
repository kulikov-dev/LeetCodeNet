using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public class AverageSalaryExcludingtheMinimumandMaximumSalary_1491_test
    {
        [Fact]
        public void CheckLinq()
        {
            var solver = new AverageSalaryExcludingtheMinimumandMaximumSalary_1491();
            //// Explanation: Minimum salary and maximum salary are 1000 and 4000 respectively.
            /// Average salary excluding minimum and maximum salary is (2000 + 3000) / 2 = 2500
            Assert.Equal(2500d, solver.AverageLinq(new int[] { 4000, 3000, 1000, 2000 }));
            Assert.Equal(2000d, solver.AverageLinq(new int[] { 1000, 2000, 3000 }));
            var salaries = new int[] { 48000, 59000, 99000, 13000, 78000, 45000, 31000, 17000, 39000, 37000, 93000, 77000, 33000, 28000, 4000, 54000, 67000, 6000, 1000, 11000 };
            Assert.Equal(41111.111, Math.Round(solver.AverageLinq(salaries), 3));
        }

        [Fact]
        public void CheckSorting()
        {
            var solver = new AverageSalaryExcludingtheMinimumandMaximumSalary_1491();
            Assert.Equal(2500d, solver.AverageSorting(new int[] { 4000, 3000, 1000, 2000 }));
            Assert.Equal(2000d, solver.AverageSorting(new int[] { 1000, 2000, 3000 }));
            var salaries = new int[] { 48000, 59000, 99000, 13000, 78000, 45000, 31000, 17000, 39000, 37000, 93000, 77000, 33000, 28000, 4000, 54000, 67000, 6000, 1000, 11000 };
            Assert.Equal(41111.111, Math.Round(solver.AverageSorting(salaries),3));
        }

        [Fact]
        public void CheckIterating()
        {
            var solver = new AverageSalaryExcludingtheMinimumandMaximumSalary_1491();
            Assert.Equal(2500d, solver.AverageIterating(new int[] { 4000, 3000, 1000, 2000 }));
            Assert.Equal(2000d, solver.AverageIterating(new int[] { 1000, 2000, 3000 }));
            var salaries = new int[] { 48000, 59000, 99000, 13000, 78000, 45000, 31000, 17000, 39000, 37000, 93000, 77000, 33000, 28000, 4000, 54000, 67000, 6000, 1000, 11000 };
            Assert.Equal(41111.111, Math.Round(solver.AverageIterating(salaries), 3));
        }
    }
}