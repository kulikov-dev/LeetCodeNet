using System.Collections;
using LeetCodeNet.DataStructs;
using LeetCodeNet.Medium.Trees;

namespace LeetCodeNet.Tests.Medium.Trees
{
    public sealed class ConvertSortedListtoBinarySearchTree_109_test
    {
        [Theory, ClassData(typeof(ConvertSortedListtoBinarySearchTreeTestData))]
        public void CheckEasy(ListNode head, TreeNode expected1, TreeNode expected2)
        {
            var solver = new ConvertSortedListtoBinarySearchTree_109();

            var result = solver.SortedListToBSTEasy(head);

            if (expected1 == null)
            {
                Assert.Null(result);
            }
            else
            {
                Assert.True(expected1.Equals(result) || expected2.Equals(result));
            }
        }

        [Theory, ClassData(typeof(ConvertSortedListtoBinarySearchTreeTestData))]
        public void CheckOptimal(ListNode head, TreeNode expected1, TreeNode expected2)
        {
            var solver = new ConvertSortedListtoBinarySearchTree_109();

            var result = solver.SortedListToBSTOptimal(head);

            if (expected1 == null)
            {
                Assert.Null(result);
            }
            else
            {
                Assert.True(expected1.Equals(result)|| expected2.Equals(result));
            }
        }
    }

    public sealed class ConvertSortedListtoBinarySearchTreeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ListNode(-10){next = new ListNode(-3){next = new ListNode(0){next = new ListNode(5){next = new ListNode(9)}}}},
                new TreeNode(0){left = new TreeNode(-10){right = new TreeNode(-3)}, right = new TreeNode(5) {right = new TreeNode(9)} },
                new TreeNode(0){left = new TreeNode(-3){left = new TreeNode(-10)}, right = new TreeNode(9) {left = new TreeNode(5)} }
            };

            yield return new object[]
            {
               null,
               null,
               null
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
