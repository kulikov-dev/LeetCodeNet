using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Easy.LeetMath
{
    /// <summary>
    /// https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/
    /// </summary>
    /// <remarks>
    /// Given head which is a reference node to a singly-linked list. The value of each node in the linked list is either 0 or 1. The linked list holds the binary representation of a number.
    /// Return the decimal value of the number in the linked list.
    /// The most significant bit is at the head of the linked list.
    /// </remarks>
    internal sealed class ConvertBinaryNumberinaLinkedListtoInteger_1290
    {
        /// <summary>
        /// Remember about binary representation of number:
        /// For example 5 = 101, where 1 * 2^2 + 0 * 2^1 + 1 * 2^0
        /// So, we can store all numbers from the List and then recreate number step by step
        /// It's not very effective, but something..
        /// </summary>
        /// <param name="head"> Head of list </param>
        /// <returns> Number </returns>
        public int GetDecimalValueSimple(ListNode head)
        {
            var newHead = head;
            var values = new Queue<int>();
            var result = 0;

            while (newHead != null)
            {
                values.Enqueue(newHead.val);

                newHead = newHead.next;
            }

            while (values.Any())
            {
                result += values.Dequeue() * (int) Math.Pow(2, values.Count);
            }

            return result;
        }

        /// <summary>
        /// Remember about binary operators, in this task - left shift operator is the key
        /// </summary>
        /// <param name="head"> Head of list </param>
        /// <returns> Number </returns>
        public int GetDecimalValueBinary(ListNode head)
        {
            var result = 0;

            while (head != null)
            {
                result <<= 1;           // Left shift num by 1 position to make way for next bit
                result += head.val;     // Add next bit to num at least significant position
                head = head.next;       
            }

            return result;
        }
    }
}
