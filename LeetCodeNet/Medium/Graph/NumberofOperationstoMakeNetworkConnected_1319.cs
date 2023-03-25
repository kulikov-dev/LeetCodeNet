namespace LeetCodeNet.Medium.Graph
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-operations-to-make-network-connected/
    /// </summary>
    /// <remarks>
    /// There are n computers numbered from 0 to n - 1 connected by ethernet cables connections forming a network where connections[i] = [ai, bi] represents a connection between computers ai and bi.
    /// Any computer can reach any other computer directly or indirectly through the network.
    /// You are given an initial computer network connections.You can extract certain cables between two directly connected computers, and place them between any pair of disconnected computers to make them directly connected.
    /// Return the minimum number of times you need to do this in order to make all the computers connected.If it is not possible, return -1.
    /// </remarks>
    internal sealed class NumberofOperationstoMakeNetworkConnected_1319
    {
        /// <summary>
        /// The best idea for all types of task where we need to check if graph vertices are connected is to use Union-Find structure.
        /// The great detailed explanation you can find here: https://www.hackerearth.com/practice/notes/disjoint-set-union-union-find/
        /// </summary>
        /// <param name="n"> Total computers </param>
        /// <param name="connections"> Connections </param>
        /// <returns> Items to connect </returns>
        /// <remarks>
        /// Time complexity:O(E*log(V)), E = edges, V = vertices
        /// Space complexity: O(V)
        /// </remarks>
        public int MakeConnected(int n, int[][] connections)
        {
            //// First check if we have enough connectors to connect all computers
            if (connections.Length < n - 1)
            {
                return -1;
            }

            var unionFinder = new UnionFind(n);

            foreach (var item in connections)
            {
                unionFinder.Union(item[0], item[1]);
            }

            return unionFinder.GetTotalRoots() - 1;
        }

        /// <summary>
        /// Union find class
        /// </summary>
        private class UnionFind
        {
            /// <summary>
            /// Array of vertices
            /// </summary>
            private readonly int[] _arr;

            /// <summary>
            /// Weights
            /// </summary>
            private readonly int[] _weights;

            /// <summary>
            /// Total unique roots of the graph
            /// </summary>
            private int _totalRoots;

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="n"> Count of vertices </param>
            public UnionFind(int n)
            {
                _arr = Enumerable.Range(0, n).ToArray();

                _weights = Enumerable.Repeat(1, n).ToArray();
                _totalRoots = n;
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

                if (_weights[rootA] < _weights[rootB])
                {
                    _arr[rootA] = rootB;
                    _weights[rootB] += _weights[rootA];
                }
                else
                {
                    _arr[rootB] = rootA;
                    _weights[rootA] += _weights[rootB];
                }

                --_totalRoots;
                return true;
            }

            /// <summary>
            /// Find root for the vertex
            /// </summary>
            /// <param name="a"> Vertex </param>
            /// <returns> Root </returns>
            public int Find(int a)
            {
                while (_arr[a] != a)
                {
                    a = _arr[a];
                }

                return a;
            }

            /// <summary>
            /// Get total unique roots
            /// </summary>
            /// <returns> Amount of unique roots </returns>
            public int GetTotalRoots()
            {
                return _totalRoots;
            }
        }
    }
}
