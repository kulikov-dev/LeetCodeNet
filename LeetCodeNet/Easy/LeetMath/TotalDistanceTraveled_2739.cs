namespace LeetCodeNet.Easy.LeetMath
{
    /// <summary>
    /// https://leetcode.com/problems/total-distance-traveled/
    /// </summary>
    /// <remarks>
    /// A truck has two fuel tanks. You are given two integers, mainTank representing the fuel present in the main tank in liters and additionalTank representing the fuel present in the additional tank in liters.
    /// The truck has a mileage of 10 km per liter.Whenever 5 liters of fuel get used up in the main tank, if the additional tank has at least 1 liters of fuel, 1 liters of fuel will be transferred from the additional tank to the main tank.
    /// Return the maximum distance which can be traveled.
    /// Note: Injection from the additional tank is not continuous. It happens suddenly and immediately for every 5 liters consumed.
    /// </remarks>
    internal sealed class TotalDistanceTraveled_2739
    {
        /// <summary>
        /// Straight solution here is to use cycle and add an additional liter for every 5 miles.
        /// Some tricks:
        ///   1. We need to keep in mind that an additional tank has not infinity fuel, so we need to track when it has any fuel.
        ///   2. Don't forget to use additional fuel to calculate if we can use an additional tank, like we have 9 liters in the main tank + 1 more liter for 5 miles from the additional tank.
        ///      So, total, we have 10 liters and can use one more liter.
        /// </summary>
        /// <param name="mainTank"> Main tank </param>
        /// <param name="additionalTank"> Additional tank </param>
        /// <returns></returns>
        /// <remarks>
        /// Time complexity: O(log(mainTank))
        /// Space complexity: O(1)
        /// </remarks>
        public int DistanceTraveled(int mainTank, int additionalTank)
        {
            var result = 0;
            const int milesPerLiter = 10;
            const int milesPerInjection = 5;

            while (mainTank - milesPerInjection >= 0)
            {
                mainTank -= milesPerInjection;
                result += milesPerInjection;

                if (additionalTank > 0)
                {
                    mainTank++;
                    --additionalTank;
                }
            }

            result += mainTank;
            return result * milesPerLiter;
        }
    }
}
