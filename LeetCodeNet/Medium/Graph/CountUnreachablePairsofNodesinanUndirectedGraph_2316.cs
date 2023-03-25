namespace LeetCodeNet.Medium.Graph
{
    /// <summary>
    /// https://leetcode.com/problems/count-unreachable-pairs-of-nodes-in-an-undirected-graph/
    /// </summary>
    /// <remarks>
    /// You are given an integer n. There is an undirected graph with n nodes, numbered from 0 to n - 1.
    /// You are given a 2D integer array edges where edges[i] = [ai, bi] denotes that there exists an undirected edge connecting nodes ai and bi.
    /// Return the number of pairs of different nodes that are unreachable from each other.
    /// </remarks>
    internal sealed class CountUnreachablePairsofNodesinanUndirectedGraph_2316
    {
        /// <summary>
        /// Edges = [[0,2],[0,5],[2,4],[1,6],[5,4]]
        /// 1. We need to make group of nodes that are connected. It's perfectly suited here to use UnionFind structure <see cref="NumberofOperationstoMakeNetworkConnected_1319"/>
        /// Groups will be {0: 4, 1: 2, 3: 1}: (0,2,5,4);(1,6);(3)
        /// 2. Having groups like (0,2,5,4);(1,6);(3) we need to calc total amount of pairs like: (4 * 2 + 4 * 1) + (2 * 1) = 14
        /// However, this give us TLE (out of time) exception
        /// 3. We can reduce complexity using equation like:
        /// group1 * group2 + (group1 + group2) * group3 + (group1 + group2 + group3) * group4, etc
        /// </summary>
        /// <param name="n"> Number of vertices </param>
        /// <param name="edges"> Edges </param>
        /// <returns> Count pairs </returns>
        /// <remarks>
        /// Time complexity:O(E*log(V)), E = edges, V = vertices
        /// Space complexity: O(V)
        /// </remarks>
        public long CountPairs(int n, int[][] edges)
        {
            var uf = new UnionFind(n);

            foreach (var item in edges)
            {
                uf.Union(item[0], item[1]);
            }

            var groups = uf.GetVerticesAmount();
            var result = 0l;
            var sum = groups[0];

            for (var i = 1; i < groups.Length; i++)
            {
                result += sum * groups[i];
                sum += groups[i];
            }

            return result;
        }

        /// <summary>
        /// Union find class
        /// </summary>
        private class UnionFind
        {
            /// <summary>
            /// Array of vertices
            /// </summary>
            private readonly int[] _data;

            /// <summary>
            /// Weights
            /// </summary>
            private readonly int[] _weight;

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="n"> Count of vertices </param>
            public UnionFind(int n)
            {
                _data = Enumerable.Range(0, n).ToArray();
                _weight = Enumerable.Repeat(1, n).ToArray();
            }

            /// <summary>
            /// Find root for the vertex
            /// </summary>
            /// <param name="a"> Vertex </param>
            /// <returns> Root </returns>
            public int Find(int i)
            {
                while (i != _data[i])
                {
                    i = _data[i];
                }

                return i;
            }

            /// <summary>
            /// Union to vertex
            /// </summary>
            /// <param name="a"> Vertex 1 </param>
            /// <param name="b"> Vertex 2 </param>
            /// <returns> True, if new connection created </returns>
            public bool Union(int a, int b)
            {
                var rootA = Find(a);
                var rootB = Find(b);

                if (rootA == rootB)
                {
                    return false;
                }

                if (_weight[rootA] > _weight[rootB])
                {
                    _data[rootB] = _data[rootA];

                    _weight[rootA] += _weight[rootB];
                }
                else
                {
                    _data[rootA] = _data[rootB];

                    _weight[rootB] += _weight[rootA];
                }

                return true;
            }

            /// <summary>
            /// Calc total amount of vertices for each root
            /// </summary>
            /// <returns> Amount </returns>
            public long[] GetVerticesAmount()
            {
                var result = new long[_data.Length];

                for (var i = 0; i < _data.Length; i++)
                {
                    var root = Find(_data[i]);

                    result[root]++;
                }

                return result;
            }
        }
    }
}
