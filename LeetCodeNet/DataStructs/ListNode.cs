namespace LeetCodeNet.DataStructs
{
    /// <summary>
    /// Class of node for LinkedList tasks
    /// </summary>
    public class ListNode
    {
        /// <summary>
        /// Value
        /// </summary>
        public int val;

        /// <summary>
        /// Link to next node
        /// </summary>
        public ListNode next;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x"> Value </param>
        public ListNode(int x)
        {
            val = x;
        }

        /// <summary>
        /// Equal lists by values
        /// </summary>
        /// <param name="node2"> Second list head </param>
        /// <returns> Lists are equal </returns>
        public bool CompareTo(ListNode? node2)
        {
            var node1 = this;
            while (node1 != null)
            {
                if (node2 == null || node1.val != node2.val)
                {
                    return false;
                }

                node1 = node1.next;
                node2 = node2.next;
            }

            return true;
        }
    }
}