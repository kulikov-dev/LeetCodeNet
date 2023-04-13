namespace LeetCodeNet.Medium.Array
{
    /// <summary>
    /// https://leetcode.com/problems/rotting-oranges/
    /// </summary>
    /// <remarks>
    /// You are given an m x n grid where each cell can have one of three values:
    /// 0 representing an empty cell,
    /// 1 representing a fresh orange, or
    /// 2 representing a rotten orange.
    /// Every minute, any fresh orange that is 4-directionally adjacent to a rotten orange becomes rotten.
    /// Return the minimum number of minutes that must elapse until no cell has a fresh orange. If this is impossible, return -1.
    /// </remarks>
    internal sealed class RottingOranges_994
    {
        /// <summary>
        /// We have to apply DFS search to process rotten oranges, but the trick here is that we need to start search from all current rotten oranges at once
        /// Those we can use Queue to store all rotten oranges here, so we can count every minute
        /// </summary>
        /// <param name="grid"> Matrix of oranges </param>
        /// <returns> Steps to rotten all oranges </returns>
        /// <remarks>
        /// Time complexity: O(n^2)
        /// Space complexity: O(n)
        /// </remarks>
        public int OrangesRotting(int[][] grid)
        {
            var counter = 0;
            var freshItems = 0;

            //// First step is to count all fresh oranges and keep all rotten to start search for all of them at once
            var rotten = new Queue<Tuple<int, int>>();

            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 2)
                    {
                        rotten.Enqueue(new Tuple<int, int>(i, j));
                    }
                    else if (grid[i][j] == 1)
                    {
                        //// To optimize solution and check if all fresh oranges are rotten now - we can use the counter of fresh ones. 
                        ++freshItems;
                    }
                }
            }

            //// If we don't have any fresh - we don't need to perform any actoins
            if (freshItems == 0)
            {
                return 0;
            }

            while (rotten.Any())
            {
                //// Keep this idea, it uses often. We keep count of the current queue to get all rotten oranges, but keep the new added
                var length = rotten.Count;

                ++counter;
                for (var i = 0; i < length; ++i)
                {
                    var item = rotten.Dequeue();

                    CheckRotting(grid, item.Item1 + 1, item.Item2, ref rotten, ref freshItems);
                    CheckRotting(grid, item.Item1 - 1, item.Item2, ref rotten, ref freshItems);
                    CheckRotting(grid, item.Item1, item.Item2 + 1, ref rotten, ref freshItems);
                    CheckRotting(grid, item.Item1, item.Item2 - 1, ref rotten, ref freshItems);
                }
            }

            return freshItems == 0 ? counter - 1 : -1;
        }

        /// <summary>
        /// Check if valid indexes and is fresh item
        /// </summary>
        /// <param name="grid"> Data </param>
        /// <param name="posI"> I </param>
        /// <param name="posJ"> J </param>
        /// <param name="rotten"> Queue of rotten items </param>
        /// <param name="freshItems"> Count if fresh items </param>
        public void CheckRotting(int[][] grid, int posI, int posJ, ref Queue<Tuple<int, int>> rotten, ref int freshItems)
        {
            //// Keep, if we in good bounds and is fresh one
            if (posI < 0 || posI == grid.Length || posJ < 0 || posJ == grid[posI].Length || grid[posI][posJ] != 1)
            {
                return;
            }

            grid[posI][posJ] = 2;       // It's not a good way to change input values. Those is better to create the new array, so our input array will untouched. But I think it's enough to say it to the interviewer

            rotten.Enqueue(new Tuple<int, int>(posI, posJ));        // It's up to you to move this out and don't use ref. It doesn't matter here.
            --freshItems;
        }
    }
}
