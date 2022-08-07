using LeetCodeNet.DataStructs;
using LeetCodeNet.Easy.LinkedList;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.LinkedList
{
    public class MergeTwoSortedLists_21_test
    {
        [Theory, ClassData(typeof(MergeTwoSortedListsTestData))]
        public void CheckRecursive(ListNode inputData1, ListNode inputData2, ListNode expected)
        {
            var solver = new MergeTwoSortedLists_21();
            var result = solver.MergeTwoListsRecursive(inputData1, inputData2);
            Assert.True(result.Equals(expected));
        }

        [Theory, ClassData(typeof(MergeTwoSortedListsTestData))]
        public void CheckIterative(ListNode inputData1, ListNode inputData2, ListNode expected)
        {
            var solver = new MergeTwoSortedLists_21();
            var result = solver.MergeTwoListsIterative(inputData1, inputData2);
            Assert.True(result.Equals(expected));
        }
    }

    public class MergeTwoSortedListsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ListNode(1){next = new ListNode(2){next = new ListNode(4)}},
                new ListNode(1){next = new ListNode(3){next = new ListNode(4)}},
                new ListNode(1){next = new ListNode(1){next = new ListNode(2){next = new ListNode(3){next = new ListNode(4){next = new ListNode(4)}}}}}
            };

            yield return new object[]
            {
                default(ListNode),
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