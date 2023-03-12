using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Hard.LinkedList
{
    /// <summary>
    /// https://leetcode.com/problems/merge-k-sorted-lists
    /// </summary>
    /// <remarks>
    /// You are given an array of k linked-lists lists, each linked-list is sorted in ascending order.
    /// Merge all the linked-lists into one sorted linked-list and return it.
    /// </remarks>
    public sealed class MergekSortedLists_23
    {
        /// <summary>
        /// Straightway solution. Store all linked lists in the array. Than sort the array and recreate the sorted linked list. Not very elegant, but at least something.
        /// </summary>
        /// <param name="lists"> Array of linked list </param>
        /// <returns> Sorted linked list </returns>
        /// <remarks>
        /// Time complexity: O(kN)
        /// Space complexity: O(N)
        /// </remarks>
        public ListNode MergeKListsBruteForse(ListNode[] lists)
        {
            var data = new List<int>();

            foreach (var list in lists)
            {
                var head = list;
                while (head != null)
                {
                    data.Add(head.val);
                    head = head.next;
                }
            }

            var newHead = new ListNode(-1);
            var currentNode = newHead;
            data.Sort();
            foreach (var item in data)
            {
                currentNode.next = new ListNode(item);
                currentNode = currentNode.next;
            }

            return newHead.next;
        }

        /// <summary>
        /// We can optimize the solution by merging elements in place. On each step, we can go through all the current nodes of the linked lists and take the one with the current minimum 
        /// </summary>
        /// <param name="lists"> Array of linked list </param>
        /// <returns> Sorted linked list </returns>
        /// <remarks>
        /// Time complexity: O(kN)
        /// Space complexity: O(1), as we merging lists in place
        /// </remarks>
        public ListNode MergeKListsIterativeByNodes(ListNode[] lists)
        {
            var newHead = new ListNode(int.MaxValue);
            var curValue = newHead;
            while (curValue != null)
            {
                curValue.next = GetNextMin(lists);
                curValue = curValue.next;
            }

            return newHead.next;
        }

        /// <summary>
        /// Helper to get the next minimum value for current nodes through all lists.
        /// </summary>
        /// <param name="lists"></param>
        /// <returns></returns>
        private ListNode GetNextMin(ListNode[] lists)
        {
            var minIndex = -1;
            var minValue = int.MaxValue;
            for (var i = 0; i < lists.Length; i++)
            {
                if (lists[i] == null)
                {
                    continue;
                }

                if (lists[i].val < minValue)
                {
                    minIndex = i;
                    minValue = lists[i].val;
                }
            }

            if (minIndex == -1)
            {
                return null;
            }

            var result = lists[minIndex];
            lists[minIndex] = lists[minIndex].next;
            return result;
        }

        public ListNode MergeKListsIterativeByLists(ListNode[] lists)
        {
            var result = lists.FirstOrDefault();
            for (var i = 1; i < lists.Length; ++i)
            {
                result = MergeLists(result, lists[i]);
            }

            return result;
        }

        /// <summary>
        /// The same idea, but now we compare linked lists by list. One list with the next one.
        /// </summary>
        /// <param name="lists"> Array of linked list </param>
        /// <returns> Sorted linked list </returns>
        /// <remarks>
        /// Time complexity: O(kN)
        /// Space complexity: O(1), as we merging lists in place
        /// </remarks>
        private ListNode MergeLists(ListNode list1, ListNode list2)
        {
            var head = new ListNode(-1);
            var currentNode = head;

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    currentNode.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    currentNode.next = list2;
                    list2 = list2.next;
                }

                currentNode = currentNode.next;
            }

            currentNode.next = list1 == null ? list2 : list1;
            return head.next;
        }
    }
}
