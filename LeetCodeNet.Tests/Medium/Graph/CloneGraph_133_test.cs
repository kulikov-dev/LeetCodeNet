using LeetCodeNet.DataStructs;
using LeetCodeNet.Medium.Graph;

namespace LeetCodeNet.Tests.Medium.Graph
{
    public sealed class CloneGraph_133_test
    {
        [Fact]
        public void Check()
        {
            var node1 = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(3);
            var node4 = new Node(4);

            node1.neighbors.Add(node2);
            node1.neighbors.Add(node4);

            node2.neighbors.Add(node1);
            node2.neighbors.Add(node3);

            node3.neighbors.Add(node2);
            node3.neighbors.Add(node4);

            node4.neighbors.Add(node3);
            node4.neighbors.Add(node1);

            var solver = new CloneGraph_133();

            var result = solver.CloneGraph(node1);

            Assert.Equal(1, result.val);
            Assert.NotSame(node1, result);
        }
    }
}