using System.Collections;
using LeetCodeNet.DataStructs;
using LeetCodeNet.Hard.LinkedList;

namespace LeetCodeNet.Tests.Hard.LinkedList
{
    public sealed class MergekSortedLists_23_test
    {
        [Theory, ClassData(typeof(MergekSortedListsTestData))]
        public void CheckBruteforce(ListNode[] inputData, ListNode expected)
        {
            var solver = new MergekSortedLists_23();
            var result = solver.MergeKListsBruteForse(inputData);

            Assert.True(result.Equals(expected));
        }

        [Theory, ClassData(typeof(MergekSortedListsTestData))]
        public void CheckIterativeByNodes(ListNode[] inputData, ListNode expected)
        {
            var solver = new MergekSortedLists_23();
            var result = solver.MergeKListsIterativeByNodes(inputData);

            Assert.True(result.Equals(expected));
        }

        [Theory, ClassData(typeof(MergekSortedListsTestData))]
        public void CheckIterativeByLists(ListNode[] inputData, ListNode expected)
        {
            var solver = new MergekSortedLists_23();
            var result = solver.MergeKListsIterativeByLists(inputData);

            Assert.True(result.Equals(expected));
        }
    }

    public sealed class MergekSortedListsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[]
                {
                    new ListNode(1){next = new ListNode(4){next = new ListNode(5)}},
                    new ListNode(1){next = new ListNode(3){next = new ListNode(4)}},
                    new ListNode(2){next = new ListNode(6)},
                },
                new ListNode(1){next = new ListNode(1){next = new ListNode(2){next = new ListNode(3){next = new ListNode(4){next = new ListNode(4){next = new ListNode(5){next = new ListNode(6)}}}}}}}
            };

            yield return new object[]
            {
                new[] 
                {
                    default(ListNode),
                    new ListNode(1),
                },
                new ListNode(1)
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}