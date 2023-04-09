using System.Collections;
using LeetCodeNet.DataStructs;
using LeetCodeNet.Medium.LinkedList;
using LeetCodeNet.Tests.Easy.LinkedList;

namespace LeetCodeNet.Tests.Medium.LinkedList
{
    public sealed class LinkedListCycleII_142_test
    {
        [Theory, ClassData(typeof(LinkedListCycleIITestData))]
        public void Check(ListNode inputData, ListNode expected)
        {
            var solver = new LinkedListCycleII_142();
            var result = solver.DetectCycle(inputData);

            Assert.True(result.Equals(expected));
        }
    }

    public sealed class LinkedListCycleIITestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var node1 = new ListNode(2);
            var node3 = new ListNode(-4) { next = node1 };
            var node2 = new ListNode(0) { next = node3 };
            node1.next = node2;
            var node = new ListNode(3) { next = node1 };
    
            yield return new object[]
            {
                node,
                node1
            };

            node = new ListNode(0);
            node1 = new ListNode(1) {next = node};
            node.next = node1;

            yield return new object[]
            {
                node,
                node
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}