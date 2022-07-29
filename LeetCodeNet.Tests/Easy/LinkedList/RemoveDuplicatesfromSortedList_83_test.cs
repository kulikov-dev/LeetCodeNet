using LeetCodeNet.DataStructs;
using LeetCodeNet.Easy.LinkedList;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.LinkedList
{
    public class RemoveDuplicatesfromSortedList_83_test
    {
        [Theory, ClassData(typeof(RemoveDuplicatesfromSortedListTestData))]
        public void CheckIterative(ListNode inputData, ListNode? expected)
        {
            var solver = new RemoveDuplicatesfromSortedList_83();
            var result = solver.DeleteDuplicatesIterative(inputData);
            while (expected != null)
            {
                Assert.Equal(expected.val, result.val);
                expected = expected.next;
                result = result.next;
            }
        }

        [Theory, ClassData(typeof(RemoveDuplicatesfromSortedListTestData))]
        public void CheckRecursive(ListNode inputData, ListNode? expected)
        {
            var solver = new RemoveDuplicatesfromSortedList_83();
            var result = solver.DeleteDuplicatesIterative(inputData);
            while (expected != null)
            {
                Assert.Equal(expected.val, result.val);
                expected = expected.next;
                result = result.next;
            }
        }
    }

    public class RemoveDuplicatesfromSortedListTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ListNode(1){next = new ListNode(1){next = new ListNode(2){next = new ListNode(2){next = new ListNode(3)}}}},
                new ListNode(1){next = new ListNode(2){next = new ListNode(3)}}
            };

            yield return new object[]
            {
                null,
                default(ListNode)
            };

            yield return new object[]
            {
                new ListNode(1){next = new ListNode(1){next = new ListNode(2){next = new ListNode(3){next = new ListNode(3)}}}},
                new ListNode(1){next = new ListNode(2){next = new ListNode(3)}}
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}