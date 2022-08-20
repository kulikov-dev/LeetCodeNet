using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Easy.LinkedList
{
    /// <summary>
    /// https://leetcode.com/problems/delete-node-in-a-linked-list/
    /// </summary>
    /// <remarks>
    /// Write a function to delete a node in a singly-linked list.You will not be given access to the head of the list, instead you will be given access to the node to be deleted directly.
    /// It is guaranteed that the node to be deleted is not a tail node in the list.
    /// </remarks>
    public sealed class DeleteNodeinaLinkedList_237
    {
        /// <summary>
        /// Copy the next node to the current node.
        /// </summary>
        /// <param name="node"> Node to remove </param>
        /// <remarks>
        /// Time complexity: O(1)
        /// Space complexity: O(1)
        /// </remarks>
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}
