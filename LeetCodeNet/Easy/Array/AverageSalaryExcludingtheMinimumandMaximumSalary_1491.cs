namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/average-salary-excluding-the-minimum-and-maximum-salary/
    /// </summary>
    public class AverageSalaryExcludingtheMinimumandMaximumSalary_1491
    {
        /// <summary>
        /// Return the average salary of employees excluding the minimum and maximum salary
        /// </summary>
        /// <param name="salary"> Array of salaries </param>
        /// <returns> Average salary </returns>
        public double AverageLinq(int[] salary)
        {
            //// Not optimal approach, as we go through array for 3 times for each linq query.
            var min = salary.Min();
            var max = salary.Max();
            var sum = salary.Sum();
            var substractSum = sum - max - min;
            //// Cast to double to prevent loss of precision.
            return substractSum / (double)(salary.Length - 2);
        }

        /// <summary>
        /// Return the average salary of employees excluding the minimum and maximum salary
        /// </summary>
        /// <param name="salary"> Array of salaries </param>
        /// <returns> Average salary </returns>
        public double AverageSorting(int[] salary)
        {
            //// The idea is to sort the array and then sum from 2 element to N-1 element
            /// It's necessary to create a new variable, as the array was passed by reference.
            /// It's not a good idea to change initial array in the real life.
            var sortedSalary = salary.OrderBy(x => x).ToArray();

            var sum = 0;
            for (var i = 1; i < sortedSalary.Length - 1; ++i)
            {
                sum += sortedSalary[i];
            }

            return sum / (double)(sortedSalary.Length - 2);
        }

        /// <summary>
        /// Return the average salary of employees excluding the minimum and maximum salary
        /// </summary>
        /// <param name="salary"> Array of salaries </param>
        /// <returns> Average salary </returns>
        public double AverageIterating(int[] salary)
        {
            //// The same approach as Linq, but we find here min/max through one pass.
            var min = int.MaxValue;
            var max = int.MinValue;
            var sum = 0;
            for (var i = 0; i < salary.Length; ++i)
            {
                var currentSalary = salary[i];
                min = Math.Min(min, currentSalary);
                max = Math.Max(max, currentSalary);
                sum += currentSalary;
            }

            return (sum - max - min) / (double)(salary.Length - 2);
        }
    }
}