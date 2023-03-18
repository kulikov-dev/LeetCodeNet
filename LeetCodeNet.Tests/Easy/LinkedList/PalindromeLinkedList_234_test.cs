using LeetCodeNet.DataStructs;
using LeetCodeNet.Easy.LinkedList;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.LinkedList
{
    public sealed class PalindromeLinkedList_234_test
    {
        [Theory, ClassData(typeof(PalindromeLinkedListTestData))]
        public void CheckStack(ListNode inputData, bool expected)
        {
            var solver = new PalindromeLinkedList_234();

            Assert.Equal(expected, solver.IsPalindromeStack(inputData));
        }

        [Theory, ClassData(typeof(PalindromeLinkedListTestData))]
        public void CheckReverse(ListNode inputData, bool expected)
        {
            var solver = new PalindromeLinkedList_234();

            Assert.Equal(expected, solver.IsPalindromeReverse(inputData));
        }
    }

    public sealed class PalindromeLinkedListTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ListNode(1){next = new ListNode(2){next = new ListNode(2){next = new ListNode(2){next = new ListNode(1)}}}},
                true
            };

            yield return new object[]
{
                new ListNode(1){next = new ListNode(2){next = new ListNode(2){next = new ListNode(1)}}},
                true
};

            yield return new object[]
            {
                new ListNode(1){next = new ListNode(1){next = new ListNode(2){next = new ListNode(3){next = new ListNode(3)}}}},
                false
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
