using System.Collections;
using LeetCodeNet.DataStructs;
using LeetCodeNet.Medium.LinkedList;

namespace LeetCodeNet.Tests.Medium.LinkedList
{
    public sealed class AddTwoNumbers_2_test
    {
        [Theory, ClassData(typeof(AddTwoNumbersTestData))]
        public void Check(ListNode inputData1, ListNode inputData2, ListNode expected)
        {
            var solver = new AddTwoNumbers_2();
            var result = solver.AddTwoNumbers(inputData1, inputData2);

            Assert.True(result.Equals(expected));
        }
    }

    public sealed class AddTwoNumbersTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: 342 + 465 = 807.
            yield return new object[]
            {
                new ListNode(2){next = new ListNode(4){next = new ListNode(3)}},
                new ListNode(5){next = new ListNode(6){next = new ListNode(4)}},
                new ListNode(7){next = new ListNode(0){next = new ListNode(8)}},
            };

            yield return new object[]
            {
                new ListNode(0),
                new ListNode(0),
                new ListNode(0),
            };

            yield return new object[]
            {
                new ListNode(9){next = new ListNode(9){next = new ListNode(9){next = new ListNode(9){next = new ListNode(9){next = new ListNode(9){next = new ListNode(9)}}}}}},
                new ListNode(9){next = new ListNode(9){next = new ListNode(9){next = new ListNode(9)}}},
                new ListNode(8){next = new ListNode(9){next = new ListNode(9){next = new ListNode(9){next = new ListNode(0){next = new ListNode(0){next = new ListNode(0){next = new ListNode(1)}}}}}}},
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}