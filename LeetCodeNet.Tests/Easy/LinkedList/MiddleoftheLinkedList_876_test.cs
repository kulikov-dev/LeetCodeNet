using LeetCodeNet.DataStructs;
using LeetCodeNet.Easy.LinkedList;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeNet.Tests.Easy.LinkedList
{
    public class MiddleoftheLinkedList_876_test
    {
        [Theory, ClassData(typeof(MiddleoftheLinkedListTestData))]
        public void Check(ListNode inputData, int expected)
        {
            var solver = new MiddleoftheLinkedList_876();
            Assert.Equal(expected, solver.MiddleNode(inputData)?.val);
        }
    }

    public class MiddleoftheLinkedListTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ListNode(1){next = new ListNode(2){next = new ListNode(3){next = new ListNode(4){next = new ListNode(5)}}}},
                3
            };

            yield return new object[]
            {
                new ListNode(1){next = new ListNode(2){next = new ListNode(3){next = new ListNode(4){next = new ListNode(5) { next = new ListNode(6)} }}}},
                4
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
