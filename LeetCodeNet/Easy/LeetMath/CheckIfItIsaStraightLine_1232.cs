namespace LeetCodeNet.Easy.LeetMath
{
    /// <summary>
    /// https://leetcode.com/problems/check-if-it-is-a-straight-line/description/
    /// </summary>
    /// <remarks>
    /// You are given an array coordinates, coordinates[i] = [x, y], where [x, y] represents the coordinate of a point. Check if these points make a straight line in the XY plane.
    /// </remarks>
    internal sealed class CheckIfItIsaStraightLine_1232
    {
        /// <summary>
        /// Check if arrays point on straight line
        /// </summary>
        /// <param name="coordinates"> Points </param>
        /// <returns> Points on straight line </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public bool CheckStraightLine(int[][] coordinates)
        {
            if (coordinates.Length < 2)
            {
                return true;
            }

            // To solve the task - we need to remind geometry, section about line slopes.
            // Slope for line with points p1 and p2 is: y2 - y1 / x2 - x1;
            // Points are on the same line, if slopes between points p1,p2,p3 are equal:
            // (y3 - y2) / (x3 - x2) = (y2 - y1) / (x2 - x1) [1]

            var x1 = coordinates[0][0];
            var y1 = coordinates[0][1];
            var x2 = coordinates[1][0];
            var y2 = coordinates[1][1];

            var dx = x2 - x1;
            var dy = y2 - y1;

            for (var i = 2; i < coordinates.Length; ++i)
            {
                // To avoid being divided by zero, transform [1] to the multiplication form:
                if (dy * (coordinates[i][0] - x2) != dx * (coordinates[i][1] - y2))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
