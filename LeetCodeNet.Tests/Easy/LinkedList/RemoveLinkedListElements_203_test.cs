using LeetCodeNet.DataStructs;
using LeetCodeNet.Easy.LinkedList;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.LinkedList
{
    public class RemoveLinkedListElements_203_test
    {
        [Theory, ClassData(typeof(RemoveLinkedListElementsTestData))]
        public void Check(ListNode inputData, int inputToRemove, ListNode? expected)
        {
            var solver = new RemoveLinkedListElements_203();
            var result = solver.RemoveElements(inputData, inputToRemove);
            Assert.True(expected?.Equals(result) ?? expected == null && result == null);
        }
    }

    public class RemoveLinkedListElementsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ListNode(6){next = new ListNode(2){next = new ListNode(3){next = new ListNode(5){next = new ListNode(6)}}}},
                6,
                new ListNode(2){next = new ListNode(3){next = new ListNode(5)}}
            };

            yield return new object[]
            {
                null,
                7,
                default(ListNode)
            };

            yield return new object[]
            {
                new ListNode(7){next = new ListNode(7){next = new ListNode(7){next = new ListNode(7){next = new ListNode(7)}}}},
                7,
                default(ListNode)
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
