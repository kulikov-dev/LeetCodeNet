namespace LeetCodeNet.Medium.Graph
{
    /// <summary>
    /// https://leetcode.com/problems/reorder-routes-to-make-all-paths-lead-to-the-city-zero
    /// </summary>
    /// <remarks>
    /// There are n cities numbered from 0 to n - 1 and n - 1 roads such that there is only one way to travel between two different cities (this network form a tree).
    /// Last year, The ministry of transport decided to orient the roads in one direction because they are too narrow.
    /// Roads are represented by connections where connections[i] = [ai, bi] represents a road from city ai to city bi.
    /// This year, there will be a big event in the capital (city 0), and many people want to travel to this city.
    /// Your task consists of reorienting some roads such that each city can visit the city 0. Return the minimum number of edges changed.
    /// It's guaranteed that each city can reach city 0 after reorder.
    /// </remarks>
    internal sealed class ReorderRoutestoMakeAllPathsLeadtotheCityZero_1466
    {
        /// <summary>
        /// 1. Create the array to represent the tree. Each node has the list of it's neighbors
        /// 2. Assign direction to each edge. If an edge goes from city2 to city, than we represent it as i -> j. Otherwise j -> -i
        /// 3. Use DFS starting from 0 city and count each time, when the edge is negative.
        /// 4. We also create an array of visited nodes to avoid recursion.
        /// </summary>
        /// <param name="n"> Total cities</param>
        /// <param name="connections"> Routes </param>
        /// <returns> Directions to change </returns>
        /// <remarks>
        /// Time complexity:O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public int MinReorder(int n, int[][] connections)
        {
            var graph = new List<int>?[n];

            foreach (var item in connections)
            {
                var fromCity = item[0];
                var toCity = item[1];

                if (graph[toCity] == null)
                {
                    graph[toCity] = new List<int>();
                }

                graph[toCity]!.Add(fromCity);

                if (graph[fromCity] == null)
                {
                    graph[fromCity] = new List<int>();
                }

                graph[fromCity]!.Add(-toCity);
            }

            var result = 0;
            var visited = new bool[n];
            var queue = new Queue<int>();

            queue.Enqueue(0);
            while (queue.Count > 0)
            {
                var edgeIndex = queue.Dequeue();
                var isReversed = edgeIndex < 0;
                edgeIndex = Math.Abs(edgeIndex);

                if (visited[edgeIndex])
                {
                    continue;
                }

                if (isReversed)
                {
                    ++result;
                }

                visited[edgeIndex] = true;
                var edges = graph[edgeIndex];

                if (edges == null)
                {
                    continue;
                }

                foreach (var item in edges)
                {
                    queue.Enqueue(item);
                }
            }

            return result;
        }
    }
}
