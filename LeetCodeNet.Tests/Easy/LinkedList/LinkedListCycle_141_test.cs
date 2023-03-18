using LeetCodeNet.DataStructs;
using LeetCodeNet.Easy.LinkedList;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.LinkedList
{
    public sealed class LinkedListCycle_141_test
    {
        [Theory, ClassData(typeof(LinkedListCycleTestData))]
        public void Check(ListNode inputData1, bool expected)
        {
            var solver = new LinkedListCycle_141();

            Assert.Equal(expected, solver.HasCycle(inputData1));
        }
    }

    public sealed class LinkedListCycleTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: There is a cycle in the linked list, where the tail connects to the 1st node (0-indexed).
            var cycledNode = new ListNode(2);
            var root = new ListNode(3) { next = cycledNode };
            cycledNode.next = new ListNode(0) { next = new ListNode(-4) { next = cycledNode } };

            yield return new object[]
            {
                root,
                true
            };

            ////  There is a cycle in the linked list, where the tail connects to the 0th node.
            cycledNode = new ListNode(2);
            root = new ListNode(1) { next = cycledNode };
            cycledNode.next = root;

            yield return new object[]
            {
                root,
                true
            };

            //// Explanation: The two strings are already equal, so no string swap operation is required.
            yield return new object[]
            {
                new ListNode(3){next = new ListNode(2){next = new ListNode(0){next = new ListNode(-4)}}},
                false
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
