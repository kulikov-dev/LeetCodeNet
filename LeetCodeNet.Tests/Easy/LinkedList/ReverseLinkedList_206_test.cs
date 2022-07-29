using LeetCodeNet.DataStructs;
using LeetCodeNet.Easy.LinkedList;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.LinkedList
{
    public class ReverseLinkedList_206_test
    {
        [Theory, ClassData(typeof(ReverseLinkedListTestData))]
        public void Check(ListNode inputData, ListNode expected)
        {
            var solver = new ReverseLinkedList_206();
            var result = solver.ReverseList(inputData);
            while (expected != null)
            {
                Assert.Equal(expected.val, result.val);
                expected = expected.next;
                result = result.next;
            }
        }
    }

    public class ReverseLinkedListTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ListNode(1){next = new ListNode(2){next = new ListNode(3){next = new ListNode(4){next = new ListNode(5)}}}},
                new ListNode(5){next = new ListNode(4){next = new ListNode(3){next = new ListNode(2){next = new ListNode(1)}}}}
            };

            yield return new object[]
          {
                new ListNode(1){next = new ListNode(2)},
                new ListNode(2){next = new ListNode(1)}
          };

            yield return new object[]
          {
                new ListNode(1),
                new ListNode(1)
          };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}