using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Medium.Graph
{
    /// <summary>
    /// https://leetcode.com/problems/clone-graph
    /// </summary>
    /// <remarks>
    /// Given a reference of a node in a connected undirected graph.
    /// Return a deep copy(clone) of the graph.
    /// </remarks>
    internal sealed class CloneGraph_133
    {
        /// <summary>
        /// To create the deep clone we need to traverse through the graph. Both approaches are suitable here: BFS/DFS.
        /// I would prefer the second one.
        /// The trick here is to prevent TLE by copying the loops.
        /// Those we will also store visited nodes.
        /// </summary>
        /// <param name="node"> First node </param>
        /// <returns> First node of the deep clone </returns>
        /// <remarks>
        /// Time complexity:O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public Node CloneGraph(Node node)
        {
            if (node == null)
            {
                return null;
            }

            var oldQueue = new Queue<Node>();
            var newNodes = new Node[101];
            var newNodesVisited = new bool[101];

            oldQueue.Enqueue(node);
            while (oldQueue.Count > 0)
            {
                var oldNode = oldQueue.Dequeue();
                var newNode = newNodes[oldNode.val] ?? new Node(oldNode.val);

                if (newNodesVisited[oldNode.val])
                {
                    continue;
                }

                newNodesVisited[oldNode.val] = true;
                newNodes[oldNode.val] = newNode;

                foreach (var childOldNode in oldNode.neighbors)
                {
                    oldQueue.Enqueue(childOldNode);

                    var childNewNode = newNodes[childOldNode.val] ?? new Node(childOldNode.val);
                    newNode.neighbors.Add(childNewNode);

                    newNodes[childOldNode.val] = childNewNode;
                }
            }

            return newNodes[node.val];
        }
    }
}
