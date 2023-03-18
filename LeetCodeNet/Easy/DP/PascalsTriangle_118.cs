namespace LeetCodeNet.Easy.DP
{
    /// <summary>
    /// Given an integer numRows, return the first numRows of Pascal's triangle.
    /// In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:
    /// </summary>
    internal sealed class PascalsTriangle_118
    {
        /// <summary>
        /// No tricks here. Fill first two rows and then calculate a current row using a previous row values.
        /// </summary>
        /// <param name="numRows"> Number of rows in a triangle </param>
        /// <returns> Pascal's triangle </returns>
        /// <remarks>
        /// Time complexity: O(i*log(j))
        /// Space complexity: O(i*log(j))
        /// </remarks>
        public IList<IList<int>> Generate(int numRows)
        {
            var result = new List<IList<int>>
            {
                new List<int>() { 1 }
            };

            if (numRows == 1)
            {
                return result;
            }

            result.Add(new List<int>() { 1, 1 });
            for (var i = 2; i < numRows; ++i)
            {
                var subResult = new List<int>();

                subResult.Add(1);

                var prevRow = result[i - 1];

                for (var j = 1; j < i; ++j)
                {
                    subResult.Add(prevRow[j - 1] + prevRow[j]);
                }

                subResult.Add(1);
                result.Add(subResult);
            }

            return result;
        }
    }
}
