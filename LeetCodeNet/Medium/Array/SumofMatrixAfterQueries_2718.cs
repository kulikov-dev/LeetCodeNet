using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeNet.Medium.Array
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// You are given an integer n and a 0-indexed 2D array queries where queries[i] = [typei, indexi, vali].
    /// Initially, there is a 0-indexed n x n matrix filled with 0's. For each query, you must apply one of the following changes:
    /// if typei == 0, set the values in the row with indexi to vali, overwriting any previous values.
    /// if typei == 1, set the values in the column with indexi to vali, overwriting any previous values.
    /// Return the sum of integers in the matrix after all queries are applied.
    /// </remarks>
    internal sealed class SumofMatrixAfterQueries_2718
    {
        /// <summary>
        /// The straight solution is to keep the matrix and change values for each query. However, it gives us TLE.
        /// The idea is to reverse queries and take only the last changes for each cell. 
        /// We can do it by tracking visited rows and columns. And taking for sum only unvisited cells.
        /// </summary>
        /// <param name="n"> Size </param>
        /// <param name="queries"> Queries </param>
        /// <returns> Sum of matrix after all queries </returns>
        /// <remarks>
        /// Time complexity: O(m), length of queries
        /// Space complexity: O(n)
        /// </remarks>
        public long MatrixSumQueries(int n, int[][] queries)
        {
            var rowsDone = new bool[n];
            var colsDone = new bool[n];
            var rowsLeft = n;
            var colsLeft = n;

            var sum = 0L;

            foreach (var query in queries.Reverse())
            {
                var type = query[0];
                var index = query[1];
                var val = query[2];

                switch (type)
                {
                    case 0:
                        if (rowsDone[index])
                        {
                            continue;
                        }

                        rowsDone[index] = true;

                        sum += colsLeft * val;
                        rowsLeft--;

                        break;
                    case 1:
                        if (colsDone[index])
                        {
                            continue;
                        }

                        colsDone[index] = true;

                        sum += rowsLeft * val;
                        colsLeft--;

                        break;
                }
            }

            return sum;
        }
    }
}
